using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRibbonFilter
	/// </summary>
	/// <remarks>
	///    create oriented ribbons from lines defined in polygonal dataset
	///
	/// vtkRibbonFilter is a filter to create oriented ribbons from lines defined
	/// in polygonal dataset. The orientation of the ribbon is along the line
	/// segments and perpendicular to "projected" line normals. Projected line
	/// normals are the original line normals projected to be perpendicular to
	/// the local line segment. An offset angle can be specified to rotate the
	/// ribbon with respect to the normal.
	///
	/// @warning
	/// The input line must not have duplicate points, or normals at points that
	/// are parallel to the incoming/outgoing line segments. (Duplicate points
	/// can be removed with vtkCleanPolyData.) If a line does not meet this
	/// criteria, then that line is not tubed.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTubeFilter
	/// </seealso>
	// Token: 0x0200056A RID: 1386
	public class vtkRibbonFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F52A RID: 62762 RVA: 0x001552A8 File Offset: 0x001534A8
		static vtkRibbonFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRibbonFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRibbonFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F52B RID: 62763 RVA: 0x001552D0 File Offset: 0x001534D0
		public vtkRibbonFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F52C RID: 62764
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRibbonFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct ribbon so that width is 0.1, the width does
		/// not vary with scalar values, and the width factor is 2.0.
		/// </summary>
		// Token: 0x0600F52D RID: 62765 RVA: 0x001552E0 File Offset: 0x001534E0
		public new static vtkRibbonFilter New()
		{
			vtkRibbonFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRibbonFilter.vtkRibbonFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRibbonFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct ribbon so that width is 0.1, the width does
		/// not vary with scalar values, and the width factor is 2.0.
		/// </summary>
		// Token: 0x0600F52E RID: 62766 RVA: 0x00155334 File Offset: 0x00153534
		public vtkRibbonFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRibbonFilter.vtkRibbonFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F52F RID: 62767 RVA: 0x00155378 File Offset: 0x00153578
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F530 RID: 62768
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRibbonFilter_GetAngle_01(HandleRef pThis);

		/// <summary>
		/// Set the offset angle of the ribbon from the line normal. (The angle
		/// is expressed in degrees.) The default is 0.0
		/// </summary>
		// Token: 0x0600F531 RID: 62769 RVA: 0x00155384 File Offset: 0x00153584
		public virtual double GetAngle()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetAngle_01(base.GetCppThis());
		}

		// Token: 0x0600F532 RID: 62770
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRibbonFilter_GetAngleMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Set the offset angle of the ribbon from the line normal. (The angle
		/// is expressed in degrees.) The default is 0.0
		/// </summary>
		// Token: 0x0600F533 RID: 62771 RVA: 0x001553A4 File Offset: 0x001535A4
		public virtual double GetAngleMaxValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetAngleMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600F534 RID: 62772
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRibbonFilter_GetAngleMinValue_03(HandleRef pThis);

		/// <summary>
		/// Set the offset angle of the ribbon from the line normal. (The angle
		/// is expressed in degrees.) The default is 0.0
		/// </summary>
		// Token: 0x0600F535 RID: 62773 RVA: 0x001553C4 File Offset: 0x001535C4
		public virtual double GetAngleMinValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetAngleMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600F536 RID: 62774
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRibbonFilter_GetDefaultNormal_04(HandleRef pThis);

		/// <summary>
		/// Set the default normal to use if no normals are supplied, and
		/// DefaultNormalOn is set. The default is (0,0,1)
		/// </summary>
		// Token: 0x0600F537 RID: 62775 RVA: 0x001553E4 File Offset: 0x001535E4
		public virtual double[] GetDefaultNormal()
		{
			IntPtr intPtr = vtkRibbonFilter.vtkRibbonFilter_GetDefaultNormal_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F538 RID: 62776
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_GetDefaultNormal_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set the default normal to use if no normals are supplied, and
		/// DefaultNormalOn is set. The default is (0,0,1)
		/// </summary>
		// Token: 0x0600F539 RID: 62777 RVA: 0x0015542C File Offset: 0x0015362C
		public virtual void GetDefaultNormal(IntPtr data)
		{
			vtkRibbonFilter.vtkRibbonFilter_GetDefaultNormal_05(base.GetCppThis(), data);
		}

		// Token: 0x0600F53A RID: 62778
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRibbonFilter_GetGenerateTCoords_06(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the ribbon with time textures, etc.
		/// </summary>
		// Token: 0x0600F53B RID: 62779 RVA: 0x0015543C File Offset: 0x0015363C
		public virtual int GetGenerateTCoords()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetGenerateTCoords_06(base.GetCppThis());
		}

		// Token: 0x0600F53C RID: 62780
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRibbonFilter_GetGenerateTCoordsAsString_07(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the ribbon with time textures, etc.
		/// </summary>
		// Token: 0x0600F53D RID: 62781 RVA: 0x0015545C File Offset: 0x0015365C
		public string GetGenerateTCoordsAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkRibbonFilter.vtkRibbonFilter_GetGenerateTCoordsAsString_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F53E RID: 62782
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRibbonFilter_GetGenerateTCoordsMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the ribbon with time textures, etc.
		/// </summary>
		// Token: 0x0600F53F RID: 62783 RVA: 0x00155498 File Offset: 0x00153698
		public virtual int GetGenerateTCoordsMaxValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetGenerateTCoordsMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600F540 RID: 62784
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRibbonFilter_GetGenerateTCoordsMinValue_09(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the ribbon with time textures, etc.
		/// </summary>
		// Token: 0x0600F541 RID: 62785 RVA: 0x001554B8 File Offset: 0x001536B8
		public virtual int GetGenerateTCoordsMinValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetGenerateTCoordsMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600F542 RID: 62786
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRibbonFilter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F543 RID: 62787 RVA: 0x001554D8 File Offset: 0x001536D8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x0600F544 RID: 62788
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRibbonFilter_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F545 RID: 62789 RVA: 0x001554F8 File Offset: 0x001536F8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x0600F546 RID: 62790
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRibbonFilter_GetTextureLength_12(HandleRef pThis);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space. The default is 1.0
		/// </summary>
		// Token: 0x0600F547 RID: 62791 RVA: 0x00155514 File Offset: 0x00153714
		public virtual double GetTextureLength()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetTextureLength_12(base.GetCppThis());
		}

		// Token: 0x0600F548 RID: 62792
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRibbonFilter_GetTextureLengthMaxValue_13(HandleRef pThis);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space. The default is 1.0
		/// </summary>
		// Token: 0x0600F549 RID: 62793 RVA: 0x00155534 File Offset: 0x00153734
		public virtual double GetTextureLengthMaxValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetTextureLengthMaxValue_13(base.GetCppThis());
		}

		// Token: 0x0600F54A RID: 62794
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRibbonFilter_GetTextureLengthMinValue_14(HandleRef pThis);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space. The default is 1.0
		/// </summary>
		// Token: 0x0600F54B RID: 62795 RVA: 0x00155554 File Offset: 0x00153754
		public virtual double GetTextureLengthMinValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetTextureLengthMinValue_14(base.GetCppThis());
		}

		// Token: 0x0600F54C RID: 62796
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRibbonFilter_GetUseDefaultNormal_15(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// The default is Off
		/// </summary>
		// Token: 0x0600F54D RID: 62797 RVA: 0x00155574 File Offset: 0x00153774
		public virtual int GetUseDefaultNormal()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetUseDefaultNormal_15(base.GetCppThis());
		}

		// Token: 0x0600F54E RID: 62798
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRibbonFilter_GetVaryWidth_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of ribbon width with scalar value.
		/// The default is Off
		/// </summary>
		// Token: 0x0600F54F RID: 62799 RVA: 0x00155594 File Offset: 0x00153794
		public virtual int GetVaryWidth()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetVaryWidth_16(base.GetCppThis());
		}

		// Token: 0x0600F550 RID: 62800
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRibbonFilter_GetWidth_17(HandleRef pThis);

		/// <summary>
		/// Set the "half" width of the ribbon. If the width is allowed to vary,
		/// this is the minimum width. The default is 0.5
		/// </summary>
		// Token: 0x0600F551 RID: 62801 RVA: 0x001555B4 File Offset: 0x001537B4
		public virtual double GetWidth()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetWidth_17(base.GetCppThis());
		}

		// Token: 0x0600F552 RID: 62802
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRibbonFilter_GetWidthFactor_18(HandleRef pThis);

		/// <summary>
		/// Set the maximum ribbon width in terms of a multiple of the minimum width.
		/// The default is 2.0
		/// </summary>
		// Token: 0x0600F553 RID: 62803 RVA: 0x001555D4 File Offset: 0x001537D4
		public virtual double GetWidthFactor()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetWidthFactor_18(base.GetCppThis());
		}

		// Token: 0x0600F554 RID: 62804
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRibbonFilter_GetWidthMaxValue_19(HandleRef pThis);

		/// <summary>
		/// Set the "half" width of the ribbon. If the width is allowed to vary,
		/// this is the minimum width. The default is 0.5
		/// </summary>
		// Token: 0x0600F555 RID: 62805 RVA: 0x001555F4 File Offset: 0x001537F4
		public virtual double GetWidthMaxValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetWidthMaxValue_19(base.GetCppThis());
		}

		// Token: 0x0600F556 RID: 62806
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRibbonFilter_GetWidthMinValue_20(HandleRef pThis);

		/// <summary>
		/// Set the "half" width of the ribbon. If the width is allowed to vary,
		/// this is the minimum width. The default is 0.5
		/// </summary>
		// Token: 0x0600F557 RID: 62807 RVA: 0x00155614 File Offset: 0x00153814
		public virtual double GetWidthMinValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetWidthMinValue_20(base.GetCppThis());
		}

		// Token: 0x0600F558 RID: 62808
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRibbonFilter_IsA_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F559 RID: 62809 RVA: 0x00155634 File Offset: 0x00153834
		public override int IsA(string type)
		{
			return vtkRibbonFilter.vtkRibbonFilter_IsA_21(base.GetCppThis(), type);
		}

		// Token: 0x0600F55A RID: 62810
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRibbonFilter_IsTypeOf_22([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F55B RID: 62811 RVA: 0x00155654 File Offset: 0x00153854
		public new static int IsTypeOf(string type)
		{
			return vtkRibbonFilter.vtkRibbonFilter_IsTypeOf_22(type);
		}

		// Token: 0x0600F55C RID: 62812
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRibbonFilter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F55D RID: 62813 RVA: 0x00155670 File Offset: 0x00153870
		public new vtkRibbonFilter NewInstance()
		{
			vtkRibbonFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRibbonFilter.vtkRibbonFilter_NewInstance_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRibbonFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F55E RID: 62814
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRibbonFilter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F55F RID: 62815 RVA: 0x001556CC File Offset: 0x001538CC
		public new static vtkRibbonFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRibbonFilter vtkRibbonFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRibbonFilter.vtkRibbonFilter_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRibbonFilter = (vtkRibbonFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRibbonFilter.Register(null);
				}
			}
			return vtkRibbonFilter;
		}

		// Token: 0x0600F560 RID: 62816
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetAngle_26(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the offset angle of the ribbon from the line normal. (The angle
		/// is expressed in degrees.) The default is 0.0
		/// </summary>
		// Token: 0x0600F561 RID: 62817 RVA: 0x0015574B File Offset: 0x0015394B
		public virtual void SetAngle(double _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetAngle_26(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F562 RID: 62818
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetDefaultNormal_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the default normal to use if no normals are supplied, and
		/// DefaultNormalOn is set. The default is (0,0,1)
		/// </summary>
		// Token: 0x0600F563 RID: 62819 RVA: 0x0015575B File Offset: 0x0015395B
		public virtual void SetDefaultNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetDefaultNormal_27(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600F564 RID: 62820
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetDefaultNormal_28(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the default normal to use if no normals are supplied, and
		/// DefaultNormalOn is set. The default is (0,0,1)
		/// </summary>
		// Token: 0x0600F565 RID: 62821 RVA: 0x0015576D File Offset: 0x0015396D
		public virtual void SetDefaultNormal(IntPtr _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetDefaultNormal_28(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F566 RID: 62822
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetGenerateTCoords_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the ribbon with time textures, etc.
		/// </summary>
		// Token: 0x0600F567 RID: 62823 RVA: 0x0015577D File Offset: 0x0015397D
		public virtual void SetGenerateTCoords(int _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetGenerateTCoords_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F568 RID: 62824
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetGenerateTCoordsToNormalizedLength_30(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the ribbon with time textures, etc.
		/// </summary>
		// Token: 0x0600F569 RID: 62825 RVA: 0x0015578D File Offset: 0x0015398D
		public void SetGenerateTCoordsToNormalizedLength()
		{
			vtkRibbonFilter.vtkRibbonFilter_SetGenerateTCoordsToNormalizedLength_30(base.GetCppThis());
		}

		// Token: 0x0600F56A RID: 62826
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetGenerateTCoordsToOff_31(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the ribbon with time textures, etc.
		/// </summary>
		// Token: 0x0600F56B RID: 62827 RVA: 0x0015579C File Offset: 0x0015399C
		public void SetGenerateTCoordsToOff()
		{
			vtkRibbonFilter.vtkRibbonFilter_SetGenerateTCoordsToOff_31(base.GetCppThis());
		}

		// Token: 0x0600F56C RID: 62828
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetGenerateTCoordsToUseLength_32(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the ribbon with time textures, etc.
		/// </summary>
		// Token: 0x0600F56D RID: 62829 RVA: 0x001557AB File Offset: 0x001539AB
		public void SetGenerateTCoordsToUseLength()
		{
			vtkRibbonFilter.vtkRibbonFilter_SetGenerateTCoordsToUseLength_32(base.GetCppThis());
		}

		// Token: 0x0600F56E RID: 62830
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetGenerateTCoordsToUseScalars_33(HandleRef pThis);

		/// <summary>
		/// Control whether and how texture coordinates are produced. This is
		/// useful for striping the ribbon with time textures, etc.
		/// </summary>
		// Token: 0x0600F56F RID: 62831 RVA: 0x001557BA File Offset: 0x001539BA
		public void SetGenerateTCoordsToUseScalars()
		{
			vtkRibbonFilter.vtkRibbonFilter_SetGenerateTCoordsToUseScalars_33(base.GetCppThis());
		}

		// Token: 0x0600F570 RID: 62832
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetTextureLength_34(HandleRef pThis, double _arg);

		/// <summary>
		/// Control the conversion of units during the texture coordinates
		/// calculation. The TextureLength indicates what length (whether
		/// calculated from scalars or length) is mapped to the [0,1)
		/// texture space. The default is 1.0
		/// </summary>
		// Token: 0x0600F571 RID: 62833 RVA: 0x001557C9 File Offset: 0x001539C9
		public virtual void SetTextureLength(double _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetTextureLength_34(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F572 RID: 62834
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetUseDefaultNormal_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// The default is Off
		/// </summary>
		// Token: 0x0600F573 RID: 62835 RVA: 0x001557D9 File Offset: 0x001539D9
		public virtual void SetUseDefaultNormal(int _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetUseDefaultNormal_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F574 RID: 62836
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetVaryWidth_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off the variation of ribbon width with scalar value.
		/// The default is Off
		/// </summary>
		// Token: 0x0600F575 RID: 62837 RVA: 0x001557E9 File Offset: 0x001539E9
		public virtual void SetVaryWidth(int _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetVaryWidth_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F576 RID: 62838
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetWidth_37(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the "half" width of the ribbon. If the width is allowed to vary,
		/// this is the minimum width. The default is 0.5
		/// </summary>
		// Token: 0x0600F577 RID: 62839 RVA: 0x001557F9 File Offset: 0x001539F9
		public virtual void SetWidth(double _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetWidth_37(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F578 RID: 62840
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_SetWidthFactor_38(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the maximum ribbon width in terms of a multiple of the minimum width.
		/// The default is 2.0
		/// </summary>
		// Token: 0x0600F579 RID: 62841 RVA: 0x00155809 File Offset: 0x00153A09
		public virtual void SetWidthFactor(double _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetWidthFactor_38(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F57A RID: 62842
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_UseDefaultNormalOff_39(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// The default is Off
		/// </summary>
		// Token: 0x0600F57B RID: 62843 RVA: 0x00155819 File Offset: 0x00153A19
		public virtual void UseDefaultNormalOff()
		{
			vtkRibbonFilter.vtkRibbonFilter_UseDefaultNormalOff_39(base.GetCppThis());
		}

		// Token: 0x0600F57C RID: 62844
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_UseDefaultNormalOn_40(HandleRef pThis);

		/// <summary>
		/// Set a boolean to control whether to use default normals.
		/// The default is Off
		/// </summary>
		// Token: 0x0600F57D RID: 62845 RVA: 0x00155828 File Offset: 0x00153A28
		public virtual void UseDefaultNormalOn()
		{
			vtkRibbonFilter.vtkRibbonFilter_UseDefaultNormalOn_40(base.GetCppThis());
		}

		// Token: 0x0600F57E RID: 62846
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_VaryWidthOff_41(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of ribbon width with scalar value.
		/// The default is Off
		/// </summary>
		// Token: 0x0600F57F RID: 62847 RVA: 0x00155837 File Offset: 0x00153A37
		public virtual void VaryWidthOff()
		{
			vtkRibbonFilter.vtkRibbonFilter_VaryWidthOff_41(base.GetCppThis());
		}

		// Token: 0x0600F580 RID: 62848
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRibbonFilter_VaryWidthOn_42(HandleRef pThis);

		/// <summary>
		/// Turn on/off the variation of ribbon width with scalar value.
		/// The default is Off
		/// </summary>
		// Token: 0x0600F581 RID: 62849 RVA: 0x00155846 File Offset: 0x00153A46
		public virtual void VaryWidthOn()
		{
			vtkRibbonFilter.vtkRibbonFilter_VaryWidthOn_42(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011E5 RID: 4581
		public new const string MRFullTypeName = "Kitware.VTK.vtkRibbonFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011E6 RID: 4582
		public new static readonly string MRClassNameKey = "class vtkRibbonFilter";
	}
}
