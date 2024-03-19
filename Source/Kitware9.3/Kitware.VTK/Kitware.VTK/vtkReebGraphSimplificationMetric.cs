using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkReebGraphSimplificationMetric
	/// </summary>
	/// <remarks>
	///    abstract class for custom Reeb graph
	/// simplification metric design.
	///
	/// This class makes it possible to design customized simplification metric
	/// evaluation algorithms, enabling the user to control the definition of what
	/// should be considered as noise or signal in the topological filtering process.
	///
	/// References:
	/// "Topological persistence and simplification",
	/// H. Edelsbrunner, D. Letscher, and A. Zomorodian,
	/// Discrete Computational Geometry, 28:511-533, 2002.
	///
	/// "Extreme elevation on a 2-manifold",
	/// P.K. Agarwal, H. Edelsbrunner, J. Harer, and Y. Wang,
	/// ACM Symposium on Computational Geometry, pp. 357-365, 2004.
	///
	/// "Simplifying flexible isosurfaces using local geometric measures",
	/// H. Carr, J. Snoeyink, M van de Panne,
	/// IEEE Visualization, 497-504, 2004
	///
	/// "Loop surgery for volumetric meshes: Reeb graphs reduced to contour trees",
	/// J. Tierny, A. Gyulassy, E. Simon, V. Pascucci,
	/// IEEE Trans. on Vis. and Comp. Graph. (Proc of IEEE VIS), 15:1177-1184, 2009.
	///
	///
	/// See Graphics/Testing/Cxx/TestReebGraph.cxx for an example of concrete
	/// implementation.
	/// </remarks>
	// Token: 0x02000ABA RID: 2746
	public class vtkReebGraphSimplificationMetric : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601CE90 RID: 118416 RVA: 0x0028B9E4 File Offset: 0x00289BE4
		static vtkReebGraphSimplificationMetric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReebGraphSimplificationMetric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReebGraphSimplificationMetric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601CE91 RID: 118417 RVA: 0x0028BA0C File Offset: 0x00289C0C
		public vtkReebGraphSimplificationMetric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601CE92 RID: 118418
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReebGraphSimplificationMetric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE93 RID: 118419 RVA: 0x0028BA1C File Offset: 0x00289C1C
		public new static vtkReebGraphSimplificationMetric New()
		{
			vtkReebGraphSimplificationMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraphSimplificationMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE94 RID: 118420 RVA: 0x0028BA70 File Offset: 0x00289C70
		public vtkReebGraphSimplificationMetric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601CE95 RID: 118421 RVA: 0x0028BAB4 File Offset: 0x00289CB4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601CE96 RID: 118422
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkReebGraphSimplificationMetric_ComputeMetric_01(HandleRef pThis, HandleRef mesh, HandleRef field, long startCriticalPoint, HandleRef vertexList, long endCriticalPoint);

		/// <summary>
		/// Function to implement in your simplification metric algorithm.
		/// Given the input mesh and the Ids of the vertices living on the Reeb graph
		/// arc to consider for removal, you should return a value between 0 and 1 (the
		/// smallest the more likely the arc will be removed, depending on the
		/// user-defined simplification threshold).
		/// </summary>
		// Token: 0x0601CE97 RID: 118423 RVA: 0x0028BAC0 File Offset: 0x00289CC0
		public virtual double ComputeMetric(vtkDataSet mesh, vtkDataArray field, long startCriticalPoint, vtkAbstractArray vertexList, long endCriticalPoint)
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_ComputeMetric_01(base.GetCppThis(), (mesh == null) ? default(HandleRef) : mesh.GetCppThis(), (field == null) ? default(HandleRef) : field.GetCppThis(), startCriticalPoint, (vertexList == null) ? default(HandleRef) : vertexList.GetCppThis(), endCriticalPoint);
		}

		// Token: 0x0601CE98 RID: 118424
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkReebGraphSimplificationMetric_GetLowerBound_02(HandleRef pThis);

		/// <summary>
		/// Set the lowest possible value for the custom metric space.
		/// This value can be set prior to launching the Reeb graph simplification and
		/// then used inside the ComputeMetric call to make sure the returned value of
		/// ComputeMetric call is indeed between 0 and 1.
		/// </summary>
		// Token: 0x0601CE99 RID: 118425 RVA: 0x0028BB24 File Offset: 0x00289D24
		public virtual double GetLowerBound()
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_GetLowerBound_02(base.GetCppThis());
		}

		// Token: 0x0601CE9A RID: 118426
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReebGraphSimplificationMetric_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE9B RID: 118427 RVA: 0x0028BB44 File Offset: 0x00289D44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601CE9C RID: 118428
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkReebGraphSimplificationMetric_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CE9D RID: 118429 RVA: 0x0028BB64 File Offset: 0x00289D64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601CE9E RID: 118430
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkReebGraphSimplificationMetric_GetUpperBound_05(HandleRef pThis);

		/// <summary>
		/// Set the highest possible value for the custom metric space.
		/// This value can be set prior to launching the Reeb graph simplification and
		/// then used inside the ComputeMetric call to make sure the returned value of
		/// ComputeMetric call is indeed between 0 and 1.
		/// </summary>
		// Token: 0x0601CE9F RID: 118431 RVA: 0x0028BB80 File Offset: 0x00289D80
		public virtual double GetUpperBound()
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_GetUpperBound_05(base.GetCppThis());
		}

		// Token: 0x0601CEA0 RID: 118432
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraphSimplificationMetric_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CEA1 RID: 118433 RVA: 0x0028BBA0 File Offset: 0x00289DA0
		public override int IsA(string type)
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601CEA2 RID: 118434
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkReebGraphSimplificationMetric_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CEA3 RID: 118435 RVA: 0x0028BBC0 File Offset: 0x00289DC0
		public new static int IsTypeOf(string type)
		{
			return vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_IsTypeOf_07(type);
		}

		// Token: 0x0601CEA4 RID: 118436
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReebGraphSimplificationMetric_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CEA5 RID: 118437 RVA: 0x0028BBDC File Offset: 0x00289DDC
		public new vtkReebGraphSimplificationMetric NewInstance()
		{
			vtkReebGraphSimplificationMetric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReebGraphSimplificationMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601CEA6 RID: 118438
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkReebGraphSimplificationMetric_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601CEA7 RID: 118439 RVA: 0x0028BC38 File Offset: 0x00289E38
		public new static vtkReebGraphSimplificationMetric SafeDownCast(vtkObjectBase o)
		{
			vtkReebGraphSimplificationMetric vtkReebGraphSimplificationMetric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReebGraphSimplificationMetric = (vtkReebGraphSimplificationMetric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReebGraphSimplificationMetric.Register(null);
				}
			}
			return vtkReebGraphSimplificationMetric;
		}

		// Token: 0x0601CEA8 RID: 118440
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReebGraphSimplificationMetric_SetLowerBound_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the lowest possible value for the custom metric space.
		/// This value can be set prior to launching the Reeb graph simplification and
		/// then used inside the ComputeMetric call to make sure the returned value of
		/// ComputeMetric call is indeed between 0 and 1.
		/// </summary>
		// Token: 0x0601CEA9 RID: 118441 RVA: 0x0028BCB7 File Offset: 0x00289EB7
		public virtual void SetLowerBound(double _arg)
		{
			vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_SetLowerBound_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0601CEAA RID: 118442
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkReebGraphSimplificationMetric_SetUpperBound_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the highest possible value for the custom metric space.
		/// This value can be set prior to launching the Reeb graph simplification and
		/// then used inside the ComputeMetric call to make sure the returned value of
		/// ComputeMetric call is indeed between 0 and 1.
		/// </summary>
		// Token: 0x0601CEAB RID: 118443 RVA: 0x0028BCC7 File Offset: 0x00289EC7
		public virtual void SetUpperBound(double _arg)
		{
			vtkReebGraphSimplificationMetric.vtkReebGraphSimplificationMetric_SetUpperBound_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E7F RID: 7807
		public new const string MRFullTypeName = "Kitware.VTK.vtkReebGraphSimplificationMetric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001E80 RID: 7808
		public new static readonly string MRClassNameKey = "class vtkReebGraphSimplificationMetric";
	}
}
