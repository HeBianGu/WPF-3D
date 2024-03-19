using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkForceStaticMesh
	/// </summary>
	/// <remarks>
	///  Takes in input as a cache the first time it is executed then use it as a static mesh
	///
	/// The Force Static Mesh filter create a cache the first time it is used using its input. It will
	/// then only update PointData, CellData and FieldData from the input if their dimensions are valid.
	/// This filter will keep the initial given geometry as long as its input keeps the same number of
	/// points and cells (and ForceCacheComputation is false). This may lead to inconsistent attributes
	/// if the geometry has changed its connectivity.
	/// This filter only impacts vtkPolyData and vtkUnstructuredGrid dataset and blocks (in composite
	/// data sets) as other data set types do not provide a GetMeshMTime method.
	/// </remarks>
	// Token: 0x02000417 RID: 1047
	public class vtkForceStaticMesh : vtkPassThrough
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C598 RID: 50584 RVA: 0x00112E1F File Offset: 0x0011101F
		static vtkForceStaticMesh()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkForceStaticMesh.MRClassNameKey, Type.GetType("Kitware.VTK.vtkForceStaticMesh"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C599 RID: 50585 RVA: 0x00112E47 File Offset: 0x00111047
		public vtkForceStaticMesh(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C59A RID: 50586
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForceStaticMesh_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C59B RID: 50587 RVA: 0x00112E58 File Offset: 0x00111058
		public new static vtkForceStaticMesh New()
		{
			vtkForceStaticMesh result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForceStaticMesh.vtkForceStaticMesh_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkForceStaticMesh)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C59C RID: 50588 RVA: 0x00112EAC File Offset: 0x001110AC
		public vtkForceStaticMesh() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkForceStaticMesh.vtkForceStaticMesh_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C59D RID: 50589 RVA: 0x00112EF0 File Offset: 0x001110F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C59E RID: 50590
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceStaticMesh_ForceCacheComputationOff_01(HandleRef pThis);

		/// <summary>
		/// When set to true, this will force this filter to recompute its cache.
		/// Default is false.
		/// </summary>
		// Token: 0x0600C59F RID: 50591 RVA: 0x00112EFB File Offset: 0x001110FB
		public virtual void ForceCacheComputationOff()
		{
			vtkForceStaticMesh.vtkForceStaticMesh_ForceCacheComputationOff_01(base.GetCppThis());
		}

		// Token: 0x0600C5A0 RID: 50592
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceStaticMesh_ForceCacheComputationOn_02(HandleRef pThis);

		/// <summary>
		/// When set to true, this will force this filter to recompute its cache.
		/// Default is false.
		/// </summary>
		// Token: 0x0600C5A1 RID: 50593 RVA: 0x00112F0A File Offset: 0x0011110A
		public virtual void ForceCacheComputationOn()
		{
			vtkForceStaticMesh.vtkForceStaticMesh_ForceCacheComputationOn_02(base.GetCppThis());
		}

		// Token: 0x0600C5A2 RID: 50594
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkForceStaticMesh_GetForceCacheComputation_03(HandleRef pThis);

		/// <summary>
		/// When set to true, this will force this filter to recompute its cache.
		/// Default is false.
		/// </summary>
		// Token: 0x0600C5A3 RID: 50595 RVA: 0x00112F1C File Offset: 0x0011111C
		public virtual bool GetForceCacheComputation()
		{
			return vtkForceStaticMesh.vtkForceStaticMesh_GetForceCacheComputation_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600C5A4 RID: 50596
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkForceStaticMesh_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5A5 RID: 50597 RVA: 0x00112F44 File Offset: 0x00111144
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkForceStaticMesh.vtkForceStaticMesh_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600C5A6 RID: 50598
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkForceStaticMesh_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5A7 RID: 50599 RVA: 0x00112F64 File Offset: 0x00111164
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkForceStaticMesh.vtkForceStaticMesh_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600C5A8 RID: 50600
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceStaticMesh_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5A9 RID: 50601 RVA: 0x00112F80 File Offset: 0x00111180
		public override int IsA(string type)
		{
			return vtkForceStaticMesh.vtkForceStaticMesh_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600C5AA RID: 50602
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkForceStaticMesh_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5AB RID: 50603 RVA: 0x00112FA0 File Offset: 0x001111A0
		public new static int IsTypeOf(string type)
		{
			return vtkForceStaticMesh.vtkForceStaticMesh_IsTypeOf_07(type);
		}

		// Token: 0x0600C5AC RID: 50604
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForceStaticMesh_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5AD RID: 50605 RVA: 0x00112FBC File Offset: 0x001111BC
		public new vtkForceStaticMesh NewInstance()
		{
			vtkForceStaticMesh result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForceStaticMesh.vtkForceStaticMesh_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkForceStaticMesh)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C5AE RID: 50606
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkForceStaticMesh_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C5AF RID: 50607 RVA: 0x00113018 File Offset: 0x00111218
		public new static vtkForceStaticMesh SafeDownCast(vtkObjectBase o)
		{
			vtkForceStaticMesh vtkForceStaticMesh = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkForceStaticMesh.vtkForceStaticMesh_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkForceStaticMesh = (vtkForceStaticMesh)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkForceStaticMesh.Register(null);
				}
			}
			return vtkForceStaticMesh;
		}

		// Token: 0x0600C5B0 RID: 50608
		[DllImport("Kitware.VTK.FiltersTemporal.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkForceStaticMesh_SetForceCacheComputation_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// When set to true, this will force this filter to recompute its cache.
		/// Default is false.
		/// </summary>
		// Token: 0x0600C5B1 RID: 50609 RVA: 0x00113097 File Offset: 0x00111297
		public virtual void SetForceCacheComputation(bool _arg)
		{
			vtkForceStaticMesh.vtkForceStaticMesh_SetForceCacheComputation_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EBE RID: 3774
		public new const string MRFullTypeName = "Kitware.VTK.vtkForceStaticMesh";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000EBF RID: 3775
		public new static readonly string MRClassNameKey = "class vtkForceStaticMesh";
	}
}
