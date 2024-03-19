using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUnstructuredGridPartialPreIntegration
	/// </summary>
	/// <remarks>
	///    performs piecewise linear ray integration.
	///
	///
	///
	/// vtkUnstructuredGridPartialPreIntegration performs piecewise linear ray
	/// integration.  This will give the same results as
	/// vtkUnstructuredGridLinearRayIntegration (with potentially a error due to
	/// table lookup quantization), but should be notably faster.  The algorithm
	/// used is given by Moreland and Angel, "A Fast High Accuracy Volume
	/// Renderer for Unstructured Data."
	///
	/// This class is thread safe only after the first instance is created.
	///
	/// </remarks>
	// Token: 0x020003A7 RID: 935
	public class vtkUnstructuredGridPartialPreIntegration : vtkUnstructuredGridVolumeRayIntegrator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A9C7 RID: 43463 RVA: 0x000F1583 File Offset: 0x000EF783
		static vtkUnstructuredGridPartialPreIntegration()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUnstructuredGridPartialPreIntegration.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridPartialPreIntegration"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A9C8 RID: 43464 RVA: 0x000F15AB File Offset: 0x000EF7AB
		public vtkUnstructuredGridPartialPreIntegration(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A9C9 RID: 43465
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9CA RID: 43466 RVA: 0x000F15BC File Offset: 0x000EF7BC
		public new static vtkUnstructuredGridPartialPreIntegration New()
		{
			vtkUnstructuredGridPartialPreIntegration result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridPartialPreIntegration)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9CB RID: 43467 RVA: 0x000F1610 File Offset: 0x000EF810
		public vtkUnstructuredGridPartialPreIntegration() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A9CC RID: 43468 RVA: 0x000F1654 File Offset: 0x000EF854
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A9CD RID: 43469
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPartialPreIntegration_BuildPsiTable_01();

		/// <summary>
		/// Looks up Psi (as defined by Moreland and Angel, "A Fast High Accuracy
		/// Volume Renderer for Unstructured Data") in a table.  The table must be
		/// created first, which happens on the first instantiation of this class
		/// or when BuildPsiTable is first called.
		/// </summary>
		// Token: 0x0600A9CE RID: 43470 RVA: 0x000F165F File Offset: 0x000EF85F
		public static void BuildPsiTable()
		{
			vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_BuildPsiTable_01();
		}

		// Token: 0x0600A9CF RID: 43471
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridPartialPreIntegration_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9D0 RID: 43472 RVA: 0x000F1668 File Offset: 0x000EF868
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600A9D1 RID: 43473
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUnstructuredGridPartialPreIntegration_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9D2 RID: 43474 RVA: 0x000F1688 File Offset: 0x000EF888
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600A9D3 RID: 43475
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_GetPsiTable_04(ref int size);

		/// <summary>
		/// Looks up Psi (as defined by Moreland and Angel, "A Fast High Accuracy
		/// Volume Renderer for Unstructured Data") in a table.  The table must be
		/// created first, which happens on the first instantiation of this class
		/// or when BuildPsiTable is first called.
		/// </summary>
		// Token: 0x0600A9D4 RID: 43476 RVA: 0x000F16A4 File Offset: 0x000EF8A4
		public static IntPtr GetPsiTable(ref int size)
		{
			return vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_GetPsiTable_04(ref size);
		}

		// Token: 0x0600A9D5 RID: 43477
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPartialPreIntegration_Initialize_05(HandleRef pThis, HandleRef volume, HandleRef scalars);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9D6 RID: 43478 RVA: 0x000F16C0 File Offset: 0x000EF8C0
		public override void Initialize(vtkVolume volume, vtkDataArray scalars)
		{
			vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_Initialize_05(base.GetCppThis(), (volume == null) ? default(HandleRef) : volume.GetCppThis(), (scalars == null) ? default(HandleRef) : scalars.GetCppThis());
		}

		// Token: 0x0600A9D7 RID: 43479
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPartialPreIntegration_Integrate_06(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9D8 RID: 43480 RVA: 0x000F1704 File Offset: 0x000EF904
		public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
		{
			vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_Integrate_06(base.GetCppThis(), (intersectionLengths == null) ? default(HandleRef) : intersectionLengths.GetCppThis(), (nearIntersections == null) ? default(HandleRef) : nearIntersections.GetCppThis(), (farIntersections == null) ? default(HandleRef) : farIntersections.GetCppThis(), color);
		}

		// Token: 0x0600A9D9 RID: 43481
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPartialPreIntegration_IntegrateRay_07(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color);

		/// <summary>
		/// Integrates a single ray segment.  \c color is blended with the result
		/// (with \c color in front).  The result is written back into \c color.
		/// </summary>
		// Token: 0x0600A9DA RID: 43482 RVA: 0x000F175F File Offset: 0x000EF95F
		public static void IntegrateRay(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color)
		{
			vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_IntegrateRay_07(length, intensity_front, attenuation_front, intensity_back, attenuation_back, color);
		}

		// Token: 0x0600A9DB RID: 43483
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUnstructuredGridPartialPreIntegration_IntegrateRay_08(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color);

		/// <summary>
		/// Integrates a single ray segment.  \c color is blended with the result
		/// (with \c color in front).  The result is written back into \c color.
		/// </summary>
		// Token: 0x0600A9DC RID: 43484 RVA: 0x000F1770 File Offset: 0x000EF970
		public static void IntegrateRay(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color)
		{
			vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_IntegrateRay_08(length, color_front, attenuation_front, color_back, attenuation_back, color);
		}

		// Token: 0x0600A9DD RID: 43485
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridPartialPreIntegration_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9DE RID: 43486 RVA: 0x000F1784 File Offset: 0x000EF984
		public override int IsA(string type)
		{
			return vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600A9DF RID: 43487
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUnstructuredGridPartialPreIntegration_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9E0 RID: 43488 RVA: 0x000F17A4 File Offset: 0x000EF9A4
		public new static int IsTypeOf(string type)
		{
			return vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_IsTypeOf_10(type);
		}

		// Token: 0x0600A9E1 RID: 43489
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9E2 RID: 43490 RVA: 0x000F17C0 File Offset: 0x000EF9C0
		public new vtkUnstructuredGridPartialPreIntegration NewInstance()
		{
			vtkUnstructuredGridPartialPreIntegration result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUnstructuredGridPartialPreIntegration)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A9E3 RID: 43491
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern float vtkUnstructuredGridPartialPreIntegration_Psi_13(float taufD, float taubD);

		/// <summary>
		/// Looks up Psi (as defined by Moreland and Angel, "A Fast High Accuracy
		/// Volume Renderer for Unstructured Data") in a table.  The table must be
		/// created first, which happens on the first instantiation of this class
		/// or when BuildPsiTable is first called.
		/// </summary>
		// Token: 0x0600A9E4 RID: 43492 RVA: 0x000F181C File Offset: 0x000EFA1C
		public static float Psi(float taufD, float taubD)
		{
			return vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_Psi_13(taufD, taubD);
		}

		// Token: 0x0600A9E5 RID: 43493
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A9E6 RID: 43494 RVA: 0x000F1838 File Offset: 0x000EFA38
		public new static vtkUnstructuredGridPartialPreIntegration SafeDownCast(vtkObjectBase o)
		{
			vtkUnstructuredGridPartialPreIntegration vtkUnstructuredGridPartialPreIntegration = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUnstructuredGridPartialPreIntegration.vtkUnstructuredGridPartialPreIntegration_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnstructuredGridPartialPreIntegration = (vtkUnstructuredGridPartialPreIntegration)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnstructuredGridPartialPreIntegration.Register(null);
				}
			}
			return vtkUnstructuredGridPartialPreIntegration;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D83 RID: 3459
		public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridPartialPreIntegration";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D84 RID: 3460
		public new static readonly string MRClassNameKey = "class vtkUnstructuredGridPartialPreIntegration";
	}
}
