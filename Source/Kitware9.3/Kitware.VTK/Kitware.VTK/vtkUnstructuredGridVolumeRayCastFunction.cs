using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridVolumeRayCastFunction
	/// </summary>
	/// <remarks>
	///    a superclass for ray casting functions
	///
	///
	/// vtkUnstructuredGridVolumeRayCastFunction is a superclass for ray casting functions that
	/// can be used within a vtkUnstructuredGridVolumeRayCastMapper.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUnstructuredGridVolumeRayCastMapper vtkUnstructuredGridVolumeRayIntegrator
	/// </seealso>
	// Token: 0x020003A2 RID: 930
	public abstract class vtkUnstructuredGridVolumeRayCastFunction : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A945 RID: 43333 RVA: 0x000F06B3 File Offset: 0x000EE8B3
		static vtkUnstructuredGridVolumeRayCastFunction()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridVolumeRayCastFunction.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeRayCastFunction"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A946 RID: 43334 RVA: 0x000F06DB File Offset: 0x000EE8DB
		public vtkUnstructuredGridVolumeRayCastFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A947 RID: 43335 RVA: 0x000F06E9 File Offset: 0x000EE8E9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A948 RID: 43336
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastFunction_Finalize_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A949 RID: 43337 RVA: 0x000F06F4 File Offset: 0x000EE8F4
		public virtual void FinalizeWrapper()
		{
			vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_Finalize_01(base.GetCppThis());
		}

		// Token: 0x0600A94A RID: 43338
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeRayCastFunction_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A94B RID: 43339 RVA: 0x000F0704 File Offset: 0x000EE904
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A94C RID: 43340
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridVolumeRayCastFunction_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A94D RID: 43341 RVA: 0x000F0724 File Offset: 0x000EE924
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A94E RID: 43342
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridVolumeRayCastFunction_Initialize_04(HandleRef pThis, HandleRef ren, HandleRef vol);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A94F RID: 43343 RVA: 0x000F0740 File Offset: 0x000EE940
		public virtual void Initialize(vtkRenderer ren, vtkVolume vol)
		{
			vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_Initialize_04(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (vol == null) ? default(HandleRef) : vol.GetCppThis());
		}

		// Token: 0x0600A950 RID: 43344
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastFunction_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A951 RID: 43345 RVA: 0x000F0784 File Offset: 0x000EE984
		public override int IsA(string type)
		{
			return vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A952 RID: 43346
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridVolumeRayCastFunction_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A953 RID: 43347 RVA: 0x000F07A4 File Offset: 0x000EE9A4
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_IsTypeOf_06(type);
		}

		// Token: 0x0600A954 RID: 43348
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastFunction_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A955 RID: 43349 RVA: 0x000F07C0 File Offset: 0x000EE9C0
		public new vtkUnstructuredGridVolumeRayCastFunction NewInstance()
		{
			vtkUnstructuredGridVolumeRayCastFunction result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A956 RID: 43350
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastFunction_NewIterator_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns a new object that will iterate over all the intersections of a
		/// ray with the cells of the input.  The calling code is responsible for
		/// deleting the returned object.
		/// </summary>
		// Token: 0x0600A957 RID: 43351 RVA: 0x000F081C File Offset: 0x000EEA1C
		public virtual vtkUnstructuredGridVolumeRayCastIterator NewIterator()
		{
			vtkUnstructuredGridVolumeRayCastIterator vtkUnstructuredGridVolumeRayCastIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_NewIterator_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastIterator = (vtkUnstructuredGridVolumeRayCastIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastIterator.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastIterator;
		}

		// Token: 0x0600A958 RID: 43352
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridVolumeRayCastFunction_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A959 RID: 43353 RVA: 0x000F088C File Offset: 0x000EEA8C
		public new static vtkUnstructuredGridVolumeRayCastFunction SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridVolumeRayCastFunction vtkUnstructuredGridVolumeRayCastFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridVolumeRayCastFunction.vtkUnstructuredGridVolumeRayCastFunction_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridVolumeRayCastFunction = (vtkUnstructuredGridVolumeRayCastFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridVolumeRayCastFunction.Register(null);
				}
			}
			return vtkUnstructuredGridVolumeRayCastFunction;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D79 RID: 3449
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeRayCastFunction";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D7A RID: 3450
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridVolumeRayCastFunction";
	}
}
