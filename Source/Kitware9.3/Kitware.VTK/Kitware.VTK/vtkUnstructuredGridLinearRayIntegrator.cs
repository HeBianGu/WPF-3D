using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridLinearRayIntegrator
	/// </summary>
	/// <remarks>
	///    performs piecewise linear ray integration.
	///
	///
	///
	/// vtkUnstructuredGridLinearRayIntegrator performs piecewise linear ray
	/// integration.  Considering that transfer functions in VTK are piecewise
	/// linear, this class should give the "correct" integration under most
	/// circumstances.  However, the computations performed are fairly hefty and
	/// should, for the most part, only be used as a benchmark for other, faster
	/// methods.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUnstructuredGridPartialPreIntegration
	///
	/// </seealso>
	// Token: 0x020003A6 RID: 934
	public class vtkUnstructuredGridLinearRayIntegrator : vtkUnstructuredGridVolumeRayIntegrator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A9AB RID: 43435 RVA: 0x000F1273 File Offset: 0x000EF473
		static vtkUnstructuredGridLinearRayIntegrator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridLinearRayIntegrator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridLinearRayIntegrator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A9AC RID: 43436 RVA: 0x000F129B File Offset: 0x000EF49B
		public vtkUnstructuredGridLinearRayIntegrator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A9AD RID: 43437
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridLinearRayIntegrator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9AE RID: 43438 RVA: 0x000F12AC File Offset: 0x000EF4AC
		public new static vtkUnstructuredGridLinearRayIntegrator New()
		{
			vtkUnstructuredGridLinearRayIntegrator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridLinearRayIntegrator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9AF RID: 43439 RVA: 0x000F1300 File Offset: 0x000EF500
		public vtkUnstructuredGridLinearRayIntegrator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A9B0 RID: 43440 RVA: 0x000F1344 File Offset: 0x000EF544
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A9B1 RID: 43441
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridLinearRayIntegrator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9B2 RID: 43442 RVA: 0x000F1350 File Offset: 0x000EF550
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600A9B3 RID: 43443
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridLinearRayIntegrator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9B4 RID: 43444 RVA: 0x000F1370 File Offset: 0x000EF570
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600A9B5 RID: 43445
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridLinearRayIntegrator_Initialize_03(HandleRef pThis, HandleRef volume, HandleRef scalars);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9B6 RID: 43446 RVA: 0x000F138C File Offset: 0x000EF58C
		public override void Initialize(vtkVolume volume, vtkDataArray scalars)
		{
			vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_Initialize_03(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		// Token: 0x0600A9B7 RID: 43447
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridLinearRayIntegrator_Integrate_04(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9B8 RID: 43448 RVA: 0x000F13D0 File Offset: 0x000EF5D0
		public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
		{
			vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_Integrate_04(base.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis(), color);
		}

		// Token: 0x0600A9B9 RID: 43449
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_05(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color);

		/// <summary>
		/// Integrates a single ray segment.  \c color is blended with the result
		/// (with \c color in front).  The result is written back into \c color.
		/// </summary>
		// Token: 0x0600A9BA RID: 43450 RVA: 0x000F142B File Offset: 0x000EF62B
		public static void IntegrateRay(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color)
		{
			vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_05(length, intensity_front, attenuation_front, intensity_back, attenuation_back, color);
		}

		// Token: 0x0600A9BB RID: 43451
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_06(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color);

		/// <summary>
		/// Integrates a single ray segment.  \c color is blended with the result
		/// (with \c color in front).  The result is written back into \c color.
		/// </summary>
		// Token: 0x0600A9BC RID: 43452 RVA: 0x000F143C File Offset: 0x000EF63C
		public static void IntegrateRay(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color)
		{
			vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_06(length, color_front, attenuation_front, color_back, attenuation_back, color);
		}

		// Token: 0x0600A9BD RID: 43453
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridLinearRayIntegrator_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9BE RID: 43454 RVA: 0x000F1450 File Offset: 0x000EF650
		public override int IsA(string type)
		{
			return vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600A9BF RID: 43455
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridLinearRayIntegrator_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9C0 RID: 43456 RVA: 0x000F1470 File Offset: 0x000EF670
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_IsTypeOf_08(type);
		}

		// Token: 0x0600A9C1 RID: 43457
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridLinearRayIntegrator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9C2 RID: 43458 RVA: 0x000F148C File Offset: 0x000EF68C
		public new vtkUnstructuredGridLinearRayIntegrator NewInstance()
		{
			vtkUnstructuredGridLinearRayIntegrator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridLinearRayIntegrator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A9C3 RID: 43459
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridLinearRayIntegrator_Psi_11(float length, float attenuation_front, float attenuation_back);

		/// <summary>
		/// Computes Psi (as defined by Moreland and Angel, "A Fast High Accuracy
		/// Volume Renderer for Unstructured Data").
		/// </summary>
		// Token: 0x0600A9C4 RID: 43460 RVA: 0x000F14E8 File Offset: 0x000EF6E8
		public static float Psi(float length, float attenuation_front, float attenuation_back)
		{
			return vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_Psi_11(length, attenuation_front, attenuation_back);
		}

		// Token: 0x0600A9C5 RID: 43461
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridLinearRayIntegrator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9C6 RID: 43462 RVA: 0x000F1504 File Offset: 0x000EF704
		public new static vtkUnstructuredGridLinearRayIntegrator SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridLinearRayIntegrator vtkUnstructuredGridLinearRayIntegrator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridLinearRayIntegrator.vtkUnstructuredGridLinearRayIntegrator_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridLinearRayIntegrator = (vtkUnstructuredGridLinearRayIntegrator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridLinearRayIntegrator.Register(null);
				}
			}
			return vtkUnstructuredGridLinearRayIntegrator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D81 RID: 3457
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridLinearRayIntegrator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D82 RID: 3458
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridLinearRayIntegrator";
	}
}
