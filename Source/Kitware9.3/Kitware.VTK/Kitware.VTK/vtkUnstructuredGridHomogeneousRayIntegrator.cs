using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridHomogeneousRayIntegrator
	/// </summary>
	/// <remarks>
	///    performs piecewise constant ray integration.
	///
	///
	///
	/// vtkUnstructuredGridHomogeneousRayIntegrator performs homogeneous ray
	/// integration.  This is a good method to use when volume rendering scalars
	/// that are defined on cells.
	///
	/// </remarks>
	// Token: 0x020003A5 RID: 933
	public class vtkUnstructuredGridHomogeneousRayIntegrator : vtkUnstructuredGridVolumeRayIntegrator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A991 RID: 43409 RVA: 0x000F0F73 File Offset: 0x000EF173
		static vtkUnstructuredGridHomogeneousRayIntegrator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridHomogeneousRayIntegrator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridHomogeneousRayIntegrator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A992 RID: 43410 RVA: 0x000F0F9B File Offset: 0x000EF19B
		public vtkUnstructuredGridHomogeneousRayIntegrator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A993 RID: 43411
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridHomogeneousRayIntegrator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A994 RID: 43412 RVA: 0x000F0FAC File Offset: 0x000EF1AC
		public new static vtkUnstructuredGridHomogeneousRayIntegrator New()
		{
			vtkUnstructuredGridHomogeneousRayIntegrator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridHomogeneousRayIntegrator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A995 RID: 43413 RVA: 0x000F1000 File Offset: 0x000EF200
		public vtkUnstructuredGridHomogeneousRayIntegrator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A996 RID: 43414 RVA: 0x000F1044 File Offset: 0x000EF244
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A997 RID: 43415
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridHomogeneousRayIntegrator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A998 RID: 43416 RVA: 0x000F1050 File Offset: 0x000EF250
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600A999 RID: 43417
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridHomogeneousRayIntegrator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A99A RID: 43418 RVA: 0x000F1070 File Offset: 0x000EF270
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600A99B RID: 43419
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridHomogeneousRayIntegrator_GetTransferFunctionTableSize_03(HandleRef pThis);

		/// <summary>
		/// For quick lookup, the transfer function is sampled into a table.
		/// This parameter sets how big of a table to use.  By default, 1024
		/// entries are used.
		/// </summary>
		// Token: 0x0600A99C RID: 43420 RVA: 0x000F108C File Offset: 0x000EF28C
		public virtual int GetTransferFunctionTableSize()
		{
			return vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_GetTransferFunctionTableSize_03(base.GetCppThis());
		}

		// Token: 0x0600A99D RID: 43421
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridHomogeneousRayIntegrator_Initialize_04(HandleRef pThis, HandleRef volume, HandleRef scalars);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A99E RID: 43422 RVA: 0x000F10AC File Offset: 0x000EF2AC
		public override void Initialize(vtkVolume volume, vtkDataArray scalars)
		{
			vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_Initialize_04(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		// Token: 0x0600A99F RID: 43423
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridHomogeneousRayIntegrator_Integrate_05(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9A0 RID: 43424 RVA: 0x000F10F0 File Offset: 0x000EF2F0
		public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
		{
			vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_Integrate_05(base.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis(), color);
		}

		// Token: 0x0600A9A1 RID: 43425
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridHomogeneousRayIntegrator_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9A2 RID: 43426 RVA: 0x000F114C File Offset: 0x000EF34C
		public override int IsA(string type)
		{
			return vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600A9A3 RID: 43427
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridHomogeneousRayIntegrator_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9A4 RID: 43428 RVA: 0x000F116C File Offset: 0x000EF36C
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_IsTypeOf_07(type);
		}

		// Token: 0x0600A9A5 RID: 43429
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridHomogeneousRayIntegrator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9A6 RID: 43430 RVA: 0x000F1188 File Offset: 0x000EF388
		public new vtkUnstructuredGridHomogeneousRayIntegrator NewInstance()
		{
			vtkUnstructuredGridHomogeneousRayIntegrator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridHomogeneousRayIntegrator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A9A7 RID: 43431
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridHomogeneousRayIntegrator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9A8 RID: 43432 RVA: 0x000F11E4 File Offset: 0x000EF3E4
		public new static vtkUnstructuredGridHomogeneousRayIntegrator SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridHomogeneousRayIntegrator vtkUnstructuredGridHomogeneousRayIntegrator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridHomogeneousRayIntegrator = (vtkUnstructuredGridHomogeneousRayIntegrator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridHomogeneousRayIntegrator.Register(null);
				}
			}
			return vtkUnstructuredGridHomogeneousRayIntegrator;
		}

		// Token: 0x0600A9A9 RID: 43433
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridHomogeneousRayIntegrator_SetTransferFunctionTableSize_11(HandleRef pThis, int _arg);

		/// <summary>
		/// For quick lookup, the transfer function is sampled into a table.
		/// This parameter sets how big of a table to use.  By default, 1024
		/// entries are used.
		/// </summary>
		// Token: 0x0600A9AA RID: 43434 RVA: 0x000F1263 File Offset: 0x000EF463
		public virtual void SetTransferFunctionTableSize(int _arg)
		{
			vtkUnstructuredGridHomogeneousRayIntegrator.vtkUnstructuredGridHomogeneousRayIntegrator_SetTransferFunctionTableSize_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D7F RID: 3455
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridHomogeneousRayIntegrator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D80 RID: 3456
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridHomogeneousRayIntegrator";
	}
}
