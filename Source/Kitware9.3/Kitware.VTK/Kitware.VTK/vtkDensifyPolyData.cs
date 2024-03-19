using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDensifyPolyData
	/// </summary>
	/// <remarks>
	///    Densify the input by adding points at the
	/// centroid
	///
	///
	/// The filter takes any polygonal data as input and will tessellate cells that
	/// are planar polygons present by fanning out triangles from its centroid.
	/// Other cells are simply passed through to the output.  PointData, if present,
	/// is interpolated via linear interpolation. CellData for any tessellated cell
	/// is simply copied over from its parent cell. Planar polygons are assumed to
	/// be convex. Funny things will happen if they are not.
	///
	/// The number of subdivisions can be controlled by the parameter
	/// NumberOfSubdivisions.
	/// </remarks>
	// Token: 0x02000892 RID: 2194
	public class vtkDensifyPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016C6C RID: 93292 RVA: 0x0020079F File Offset: 0x001FE99F
		static vtkDensifyPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDensifyPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDensifyPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016C6D RID: 93293 RVA: 0x002007C7 File Offset: 0x001FE9C7
		public vtkDensifyPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016C6E RID: 93294
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDensifyPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C6F RID: 93295 RVA: 0x002007D8 File Offset: 0x001FE9D8
		public new static vtkDensifyPolyData New()
		{
			vtkDensifyPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDensifyPolyData.vtkDensifyPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDensifyPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C70 RID: 93296 RVA: 0x0020082C File Offset: 0x001FEA2C
		public vtkDensifyPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDensifyPolyData.vtkDensifyPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016C71 RID: 93297 RVA: 0x00200870 File Offset: 0x001FEA70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016C72 RID: 93298
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDensifyPolyData_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C73 RID: 93299 RVA: 0x0020087C File Offset: 0x001FEA7C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDensifyPolyData.vtkDensifyPolyData_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016C74 RID: 93300
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDensifyPolyData_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C75 RID: 93301 RVA: 0x0020089C File Offset: 0x001FEA9C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDensifyPolyData.vtkDensifyPolyData_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016C76 RID: 93302
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkDensifyPolyData_GetNumberOfSubdivisions_03(HandleRef pThis);

		/// <summary>
		/// Number of recursive subdivisions. Initial value is 1.
		/// </summary>
		// Token: 0x06016C77 RID: 93303 RVA: 0x002008B8 File Offset: 0x001FEAB8
		public virtual uint GetNumberOfSubdivisions()
		{
			return vtkDensifyPolyData.vtkDensifyPolyData_GetNumberOfSubdivisions_03(base.GetCppThis());
		}

		// Token: 0x06016C78 RID: 93304
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPolyData_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C79 RID: 93305 RVA: 0x002008D8 File Offset: 0x001FEAD8
		public override int IsA(string type)
		{
			return vtkDensifyPolyData.vtkDensifyPolyData_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016C7A RID: 93306
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDensifyPolyData_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C7B RID: 93307 RVA: 0x002008F8 File Offset: 0x001FEAF8
		public new static int IsTypeOf(string type)
		{
			return vtkDensifyPolyData.vtkDensifyPolyData_IsTypeOf_05(type);
		}

		// Token: 0x06016C7C RID: 93308
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDensifyPolyData_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C7D RID: 93309 RVA: 0x00200914 File Offset: 0x001FEB14
		public new vtkDensifyPolyData NewInstance()
		{
			vtkDensifyPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDensifyPolyData.vtkDensifyPolyData_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDensifyPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016C7E RID: 93310
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDensifyPolyData_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C7F RID: 93311 RVA: 0x00200970 File Offset: 0x001FEB70
		public new static vtkDensifyPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkDensifyPolyData vtkDensifyPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDensifyPolyData.vtkDensifyPolyData_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDensifyPolyData = (vtkDensifyPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDensifyPolyData.Register(null);
				}
			}
			return vtkDensifyPolyData;
		}

		// Token: 0x06016C80 RID: 93312
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDensifyPolyData_SetNumberOfSubdivisions_09(HandleRef pThis, uint _arg);

		/// <summary>
		/// Number of recursive subdivisions. Initial value is 1.
		/// </summary>
		// Token: 0x06016C81 RID: 93313 RVA: 0x002009EF File Offset: 0x001FEBEF
		public virtual void SetNumberOfSubdivisions(uint _arg)
		{
			vtkDensifyPolyData.vtkDensifyPolyData_SetNumberOfSubdivisions_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001985 RID: 6533
		public new const string MRFullTypeName = "Kitware.VTK.vtkDensifyPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001986 RID: 6534
		public new static readonly string MRClassNameKey = "class vtkDensifyPolyData";
	}
}
