using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumeOutlineSource
	/// </summary>
	/// <remarks>
	///    outline of volume cropping region
	///
	/// vtkVolumeOutlineSource generates a wireframe outline that corresponds
	/// to the cropping region of a vtkVolumeMapper.  It requires a
	/// vtkVolumeMapper as input.  The GenerateFaces option turns on the
	/// solid faces of the outline, and the GenerateScalars option generates
	/// color scalars.  When GenerateScalars is on, it is possible to set
	/// an "ActivePlaneId" value in the range [0..6] to highlight one of the
	/// six cropping planes.
	/// @par Thanks:
	/// Thanks to David Gobbi for contributing this class to VTK.
	/// </remarks>
	// Token: 0x020003AC RID: 940
	public class vtkVolumeOutlineSource : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600AAF6 RID: 43766 RVA: 0x000F2EE3 File Offset: 0x000F10E3
		static vtkVolumeOutlineSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeOutlineSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeOutlineSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600AAF7 RID: 43767 RVA: 0x000F2F0B File Offset: 0x000F110B
		public vtkVolumeOutlineSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600AAF8 RID: 43768
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOutlineSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AAF9 RID: 43769 RVA: 0x000F2F1C File Offset: 0x000F111C
		public new static vtkVolumeOutlineSource New()
		{
			vtkVolumeOutlineSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeOutlineSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AAFA RID: 43770 RVA: 0x000F2F70 File Offset: 0x000F1170
		public vtkVolumeOutlineSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumeOutlineSource.vtkVolumeOutlineSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600AAFB RID: 43771 RVA: 0x000F2FB4 File Offset: 0x000F11B4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600AAFC RID: 43772
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_GenerateFacesOff_01(HandleRef pThis);

		/// <summary>
		/// Set whether to generate polygonal faces for the output.  By default,
		/// only lines are generated.  The faces will form a closed, watertight
		/// surface.
		/// </summary>
		// Token: 0x0600AAFD RID: 43773 RVA: 0x000F2FBF File Offset: 0x000F11BF
		public virtual void GenerateFacesOff()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateFacesOff_01(base.GetCppThis());
		}

		// Token: 0x0600AAFE RID: 43774
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_GenerateFacesOn_02(HandleRef pThis);

		/// <summary>
		/// Set whether to generate polygonal faces for the output.  By default,
		/// only lines are generated.  The faces will form a closed, watertight
		/// surface.
		/// </summary>
		// Token: 0x0600AAFF RID: 43775 RVA: 0x000F2FCE File Offset: 0x000F11CE
		public virtual void GenerateFacesOn()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateFacesOn_02(base.GetCppThis());
		}

		// Token: 0x0600AB00 RID: 43776
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_GenerateOutlineOff_03(HandleRef pThis);

		/// <summary>
		/// Set whether to generate an outline wherever an input face was
		/// cut by a plane.  This is on by default.
		/// </summary>
		// Token: 0x0600AB01 RID: 43777 RVA: 0x000F2FDD File Offset: 0x000F11DD
		public virtual void GenerateOutlineOff()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateOutlineOff_03(base.GetCppThis());
		}

		// Token: 0x0600AB02 RID: 43778
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_GenerateOutlineOn_04(HandleRef pThis);

		/// <summary>
		/// Set whether to generate an outline wherever an input face was
		/// cut by a plane.  This is on by default.
		/// </summary>
		// Token: 0x0600AB03 RID: 43779 RVA: 0x000F2FEC File Offset: 0x000F11EC
		public virtual void GenerateOutlineOn()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateOutlineOn_04(base.GetCppThis());
		}

		// Token: 0x0600AB04 RID: 43780
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_GenerateScalarsOff_05(HandleRef pThis);

		/// <summary>
		/// Set whether to generate color scalars for the output.  By default,
		/// the output has no scalars and the color must be set in the
		/// property of the actor.
		/// </summary>
		// Token: 0x0600AB05 RID: 43781 RVA: 0x000F2FFB File Offset: 0x000F11FB
		public virtual void GenerateScalarsOff()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateScalarsOff_05(base.GetCppThis());
		}

		// Token: 0x0600AB06 RID: 43782
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_GenerateScalarsOn_06(HandleRef pThis);

		/// <summary>
		/// Set whether to generate color scalars for the output.  By default,
		/// the output has no scalars and the color must be set in the
		/// property of the actor.
		/// </summary>
		// Token: 0x0600AB07 RID: 43783 RVA: 0x000F300A File Offset: 0x000F120A
		public virtual void GenerateScalarsOn()
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GenerateScalarsOn_06(base.GetCppThis());
		}

		// Token: 0x0600AB08 RID: 43784
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOutlineSource_GetActivePlaneColor_07(HandleRef pThis);

		/// <summary>
		/// Set the color of the active cropping plane.  This has no effect unless
		/// GenerateScalars is On and ActivePlaneId is non-negative.  The default
		/// color is yellow.
		/// </summary>
		// Token: 0x0600AB09 RID: 43785 RVA: 0x000F301C File Offset: 0x000F121C
		public virtual double[] GetActivePlaneColor()
		{
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetActivePlaneColor_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AB0A RID: 43786
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_GetActivePlaneColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the color of the active cropping plane.  This has no effect unless
		/// GenerateScalars is On and ActivePlaneId is non-negative.  The default
		/// color is yellow.
		/// </summary>
		// Token: 0x0600AB0B RID: 43787 RVA: 0x000F3064 File Offset: 0x000F1264
		public virtual void GetActivePlaneColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetActivePlaneColor_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600AB0C RID: 43788
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_GetActivePlaneColor_09(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the active cropping plane.  This has no effect unless
		/// GenerateScalars is On and ActivePlaneId is non-negative.  The default
		/// color is yellow.
		/// </summary>
		// Token: 0x0600AB0D RID: 43789 RVA: 0x000F3076 File Offset: 0x000F1276
		public virtual void GetActivePlaneColor(IntPtr _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetActivePlaneColor_09(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB0E RID: 43790
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOutlineSource_GetActivePlaneId_10(HandleRef pThis);

		/// <summary>
		/// Set the active plane, e.g. to display which plane is currently being
		/// modified by an interaction.  Set this to -1 if there is no active plane.
		/// The default value is -1.
		/// </summary>
		// Token: 0x0600AB0F RID: 43791 RVA: 0x000F3088 File Offset: 0x000F1288
		public virtual int GetActivePlaneId()
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetActivePlaneId_10(base.GetCppThis());
		}

		// Token: 0x0600AB10 RID: 43792
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOutlineSource_GetColor_11(HandleRef pThis);

		/// <summary>
		/// Set the color of the outline.  This has no effect unless GenerateScalars
		/// is On.  The default color is red.
		/// </summary>
		// Token: 0x0600AB11 RID: 43793 RVA: 0x000F30A8 File Offset: 0x000F12A8
		public virtual double[] GetColor()
		{
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetColor_11(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600AB12 RID: 43794
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_GetColor_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the color of the outline.  This has no effect unless GenerateScalars
		/// is On.  The default color is red.
		/// </summary>
		// Token: 0x0600AB13 RID: 43795 RVA: 0x000F30F0 File Offset: 0x000F12F0
		public virtual void GetColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetColor_12(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600AB14 RID: 43796
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_GetColor_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the outline.  This has no effect unless GenerateScalars
		/// is On.  The default color is red.
		/// </summary>
		// Token: 0x0600AB15 RID: 43797 RVA: 0x000F3102 File Offset: 0x000F1302
		public virtual void GetColor(IntPtr _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetColor_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB16 RID: 43798
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOutlineSource_GetGenerateFaces_14(HandleRef pThis);

		/// <summary>
		/// Set whether to generate polygonal faces for the output.  By default,
		/// only lines are generated.  The faces will form a closed, watertight
		/// surface.
		/// </summary>
		// Token: 0x0600AB17 RID: 43799 RVA: 0x000F3114 File Offset: 0x000F1314
		public virtual int GetGenerateFaces()
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetGenerateFaces_14(base.GetCppThis());
		}

		// Token: 0x0600AB18 RID: 43800
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOutlineSource_GetGenerateOutline_15(HandleRef pThis);

		/// <summary>
		/// Set whether to generate an outline wherever an input face was
		/// cut by a plane.  This is on by default.
		/// </summary>
		// Token: 0x0600AB19 RID: 43801 RVA: 0x000F3134 File Offset: 0x000F1334
		public virtual int GetGenerateOutline()
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetGenerateOutline_15(base.GetCppThis());
		}

		// Token: 0x0600AB1A RID: 43802
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOutlineSource_GetGenerateScalars_16(HandleRef pThis);

		/// <summary>
		/// Set whether to generate color scalars for the output.  By default,
		/// the output has no scalars and the color must be set in the
		/// property of the actor.
		/// </summary>
		// Token: 0x0600AB1B RID: 43803 RVA: 0x000F3154 File Offset: 0x000F1354
		public virtual int GetGenerateScalars()
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetGenerateScalars_16(base.GetCppThis());
		}

		// Token: 0x0600AB1C RID: 43804
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeOutlineSource_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB1D RID: 43805 RVA: 0x000F3174 File Offset: 0x000F1374
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x0600AB1E RID: 43806
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeOutlineSource_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB1F RID: 43807 RVA: 0x000F3194 File Offset: 0x000F1394
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x0600AB20 RID: 43808
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOutlineSource_GetVolumeMapper_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the mapper that has the cropping region that the outline will
		/// be generated for.  The mapper must have an input, because the
		/// bounds of the data must be computed in order to generate the
		/// outline.
		/// </summary>
		// Token: 0x0600AB21 RID: 43809 RVA: 0x000F31B0 File Offset: 0x000F13B0
		public vtkVolumeMapper GetVolumeMapper()
		{
			vtkVolumeMapper vtkVolumeMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_GetVolumeMapper_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeMapper = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeMapper.Register(null);
				}
			}
			return vtkVolumeMapper;
		}

		// Token: 0x0600AB22 RID: 43810
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOutlineSource_IsA_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB23 RID: 43811 RVA: 0x000F3220 File Offset: 0x000F1420
		public override int IsA(string type)
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_IsA_20(base.GetCppThis(), type);
		}

		// Token: 0x0600AB24 RID: 43812
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeOutlineSource_IsTypeOf_21([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB25 RID: 43813 RVA: 0x000F3240 File Offset: 0x000F1440
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeOutlineSource.vtkVolumeOutlineSource_IsTypeOf_21(type);
		}

		// Token: 0x0600AB26 RID: 43814
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOutlineSource_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB27 RID: 43815 RVA: 0x000F325C File Offset: 0x000F145C
		public new vtkVolumeOutlineSource NewInstance()
		{
			vtkVolumeOutlineSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_NewInstance_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeOutlineSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600AB28 RID: 43816
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeOutlineSource_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600AB29 RID: 43817 RVA: 0x000F32B8 File Offset: 0x000F14B8
		public new static vtkVolumeOutlineSource SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeOutlineSource vtkVolumeOutlineSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeOutlineSource.vtkVolumeOutlineSource_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeOutlineSource = (vtkVolumeOutlineSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeOutlineSource.Register(null);
				}
			}
			return vtkVolumeOutlineSource;
		}

		// Token: 0x0600AB2A RID: 43818
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_SetActivePlaneColor_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color of the active cropping plane.  This has no effect unless
		/// GenerateScalars is On and ActivePlaneId is non-negative.  The default
		/// color is yellow.
		/// </summary>
		// Token: 0x0600AB2B RID: 43819 RVA: 0x000F3337 File Offset: 0x000F1537
		public virtual void SetActivePlaneColor(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetActivePlaneColor_25(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600AB2C RID: 43820
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_SetActivePlaneColor_26(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the active cropping plane.  This has no effect unless
		/// GenerateScalars is On and ActivePlaneId is non-negative.  The default
		/// color is yellow.
		/// </summary>
		// Token: 0x0600AB2D RID: 43821 RVA: 0x000F3349 File Offset: 0x000F1549
		public virtual void SetActivePlaneColor(IntPtr _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetActivePlaneColor_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB2E RID: 43822
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_SetActivePlaneId_27(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the active plane, e.g. to display which plane is currently being
		/// modified by an interaction.  Set this to -1 if there is no active plane.
		/// The default value is -1.
		/// </summary>
		// Token: 0x0600AB2F RID: 43823 RVA: 0x000F3359 File Offset: 0x000F1559
		public virtual void SetActivePlaneId(int _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetActivePlaneId_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB30 RID: 43824
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_SetColor_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color of the outline.  This has no effect unless GenerateScalars
		/// is On.  The default color is red.
		/// </summary>
		// Token: 0x0600AB31 RID: 43825 RVA: 0x000F3369 File Offset: 0x000F1569
		public virtual void SetColor(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetColor_28(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600AB32 RID: 43826
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_SetColor_29(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color of the outline.  This has no effect unless GenerateScalars
		/// is On.  The default color is red.
		/// </summary>
		// Token: 0x0600AB33 RID: 43827 RVA: 0x000F337B File Offset: 0x000F157B
		public virtual void SetColor(IntPtr _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetColor_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB34 RID: 43828
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_SetGenerateFaces_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to generate polygonal faces for the output.  By default,
		/// only lines are generated.  The faces will form a closed, watertight
		/// surface.
		/// </summary>
		// Token: 0x0600AB35 RID: 43829 RVA: 0x000F338B File Offset: 0x000F158B
		public virtual void SetGenerateFaces(int _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetGenerateFaces_30(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB36 RID: 43830
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_SetGenerateOutline_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to generate an outline wherever an input face was
		/// cut by a plane.  This is on by default.
		/// </summary>
		// Token: 0x0600AB37 RID: 43831 RVA: 0x000F339B File Offset: 0x000F159B
		public virtual void SetGenerateOutline(int _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetGenerateOutline_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB38 RID: 43832
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_SetGenerateScalars_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to generate color scalars for the output.  By default,
		/// the output has no scalars and the color must be set in the
		/// property of the actor.
		/// </summary>
		// Token: 0x0600AB39 RID: 43833 RVA: 0x000F33AB File Offset: 0x000F15AB
		public virtual void SetGenerateScalars(int _arg)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetGenerateScalars_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AB3A RID: 43834
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeOutlineSource_SetVolumeMapper_33(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Set the mapper that has the cropping region that the outline will
		/// be generated for.  The mapper must have an input, because the
		/// bounds of the data must be computed in order to generate the
		/// outline.
		/// </summary>
		// Token: 0x0600AB3B RID: 43835 RVA: 0x000F33BC File Offset: 0x000F15BC
		public virtual void SetVolumeMapper(vtkVolumeMapper mapper)
		{
			vtkVolumeOutlineSource.vtkVolumeOutlineSource_SetVolumeMapper_33(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D8D RID: 3469
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeOutlineSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D8E RID: 3470
		public new static readonly string MRClassNameKey = "class vtkVolumeOutlineSource";
	}
}
