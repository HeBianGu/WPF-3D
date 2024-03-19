using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSlabReslice
	/// </summary>
	/// <remarks>
	///    Thick slab reformat through data.
	///
	/// This class derives from vtkImageResliceBase. Much like vtkImageReslice, it
	/// reslices the data. It is multi-threaded. It takes a three dimensional image
	/// as input and produces a two dimensional thick MPR along some direction.
	/// &lt;p&gt; The class reslices the thick slab using a blending function. Supported
	/// blending functions are Minimum Intensity blend through the slab, maximum
	/// intensity blend and a Mean (average) intensity of values across the slab.
	/// &lt;p&gt; The user can adjust the thickness of the slab by using the method
	/// SetSlabThickness. The distance between sample points used for blending
	/// across the thickness of the slab is controlled by the method
	/// SetSlabResolution. These two methods determine the number of slices used
	/// across the slab for blending, which is computed as
	/// {(2 x (int)(0.5 x SlabThickness/SlabResolution)) + 1}. This value may
	/// be queried via GetNumBlendSamplePoints() and is always &gt;= 1.
	/// &lt;p&gt; Much like vtkImageReslice, the reslice axes direction cosines may be
	/// set via the methods SetResliceAxes or SetResliceAxesDirectionCosines. The
	/// output spacing is controlled by SetOutputSpacing and the output origin is
	/// controlled by SetOutputOrigin. The default value to be set on pixels that
	/// lie outside the volume when reformatting is controlled by
	/// SetBackgroundColor or SetBackgroundLevel. The SetResliceAxesOrigin()
	/// method can also be used to provide an (x,y,z) point that the slice will
	/// pass through.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageReslice
	/// </seealso>
	// Token: 0x02000490 RID: 1168
	public class vtkImageSlabReslice : vtkImageReslice
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D72F RID: 55087 RVA: 0x0012B195 File Offset: 0x00129395
		static vtkImageSlabReslice()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSlabReslice.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSlabReslice"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D730 RID: 55088 RVA: 0x0012B1BD File Offset: 0x001293BD
		public vtkImageSlabReslice(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D731 RID: 55089
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlabReslice_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D732 RID: 55090 RVA: 0x0012B1CC File Offset: 0x001293CC
		public new static vtkImageSlabReslice New()
		{
			vtkImageSlabReslice result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlabReslice.vtkImageSlabReslice_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSlabReslice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D733 RID: 55091 RVA: 0x0012B220 File Offset: 0x00129420
		public vtkImageSlabReslice() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSlabReslice.vtkImageSlabReslice_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D734 RID: 55092 RVA: 0x0012B264 File Offset: 0x00129464
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D735 RID: 55093
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlabReslice_GetBlendMode_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode. Default is MIP (ie Max)
		/// </summary>
		// Token: 0x0600D736 RID: 55094 RVA: 0x0012B270 File Offset: 0x00129470
		public virtual int GetBlendMode()
		{
			return vtkImageSlabReslice.vtkImageSlabReslice_GetBlendMode_01(base.GetCppThis());
		}

		// Token: 0x0600D737 RID: 55095
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlabReslice_GetNumBlendSamplePoints_02(HandleRef pThis);

		/// <summary>
		/// Number of sample points used across the slab cross-section. If equal to
		/// 1, this ends up being a thin reslice through the data a.k.a.
		/// vtkImageReslice
		/// </summary>
		// Token: 0x0600D738 RID: 55096 RVA: 0x0012B290 File Offset: 0x00129490
		public virtual int GetNumBlendSamplePoints()
		{
			return vtkImageSlabReslice.vtkImageSlabReslice_GetNumBlendSamplePoints_02(base.GetCppThis());
		}

		// Token: 0x0600D739 RID: 55097
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSlabReslice_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D73A RID: 55098 RVA: 0x0012B2B0 File Offset: 0x001294B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSlabReslice.vtkImageSlabReslice_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D73B RID: 55099
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSlabReslice_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D73C RID: 55100 RVA: 0x0012B2D0 File Offset: 0x001294D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSlabReslice.vtkImageSlabReslice_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600D73D RID: 55101
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSlabReslice_GetSlabResolution_05(HandleRef pThis);

		/// <summary>
		/// Spacing between slabs in world units. (Number of Slices, ie samples to
		/// blend is computed from SlabThickness and SlabResolution).
		/// </summary>
		// Token: 0x0600D73E RID: 55102 RVA: 0x0012B2EC File Offset: 0x001294EC
		public virtual double GetSlabResolution()
		{
			return vtkImageSlabReslice.vtkImageSlabReslice_GetSlabResolution_05(base.GetCppThis());
		}

		// Token: 0x0600D73F RID: 55103
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageSlabReslice_GetSlabThickness_06(HandleRef pThis);

		/// <summary>
		/// SlabThickness of slab in world coords. SlabThickness must be non-zero and
		/// positive.
		/// </summary>
		// Token: 0x0600D740 RID: 55104 RVA: 0x0012B30C File Offset: 0x0012950C
		public virtual double GetSlabThickness()
		{
			return vtkImageSlabReslice.vtkImageSlabReslice_GetSlabThickness_06(base.GetCppThis());
		}

		// Token: 0x0600D741 RID: 55105
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlabReslice_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D742 RID: 55106 RVA: 0x0012B32C File Offset: 0x0012952C
		public override int IsA(string type)
		{
			return vtkImageSlabReslice.vtkImageSlabReslice_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600D743 RID: 55107
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSlabReslice_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D744 RID: 55108 RVA: 0x0012B34C File Offset: 0x0012954C
		public new static int IsTypeOf(string type)
		{
			return vtkImageSlabReslice.vtkImageSlabReslice_IsTypeOf_08(type);
		}

		// Token: 0x0600D745 RID: 55109
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlabReslice_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D746 RID: 55110 RVA: 0x0012B368 File Offset: 0x00129568
		public new vtkImageSlabReslice NewInstance()
		{
			vtkImageSlabReslice result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlabReslice.vtkImageSlabReslice_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSlabReslice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D747 RID: 55111
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSlabReslice_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D748 RID: 55112 RVA: 0x0012B3C4 File Offset: 0x001295C4
		public new static vtkImageSlabReslice SafeDownCast(vtkObjectBase o)
		{
			vtkImageSlabReslice vtkImageSlabReslice = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSlabReslice.vtkImageSlabReslice_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSlabReslice = (vtkImageSlabReslice)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSlabReslice.Register(null);
				}
			}
			return vtkImageSlabReslice;
		}

		// Token: 0x0600D749 RID: 55113
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlabReslice_SetBlendMode_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the blend mode. Default is MIP (ie Max)
		/// </summary>
		// Token: 0x0600D74A RID: 55114 RVA: 0x0012B443 File Offset: 0x00129643
		public virtual void SetBlendMode(int _arg)
		{
			vtkImageSlabReslice.vtkImageSlabReslice_SetBlendMode_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D74B RID: 55115
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlabReslice_SetBlendModeToMax_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode. Default is MIP (ie Max)
		/// </summary>
		// Token: 0x0600D74C RID: 55116 RVA: 0x0012B453 File Offset: 0x00129653
		public void SetBlendModeToMax()
		{
			vtkImageSlabReslice.vtkImageSlabReslice_SetBlendModeToMax_13(base.GetCppThis());
		}

		// Token: 0x0600D74D RID: 55117
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlabReslice_SetBlendModeToMean_14(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode. Default is MIP (ie Max)
		/// </summary>
		// Token: 0x0600D74E RID: 55118 RVA: 0x0012B462 File Offset: 0x00129662
		public void SetBlendModeToMean()
		{
			vtkImageSlabReslice.vtkImageSlabReslice_SetBlendModeToMean_14(base.GetCppThis());
		}

		// Token: 0x0600D74F RID: 55119
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlabReslice_SetBlendModeToMin_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the blend mode. Default is MIP (ie Max)
		/// </summary>
		// Token: 0x0600D750 RID: 55120 RVA: 0x0012B471 File Offset: 0x00129671
		public void SetBlendModeToMin()
		{
			vtkImageSlabReslice.vtkImageSlabReslice_SetBlendModeToMin_15(base.GetCppThis());
		}

		// Token: 0x0600D751 RID: 55121
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlabReslice_SetSlabResolution_16(HandleRef pThis, double _arg);

		/// <summary>
		/// Spacing between slabs in world units. (Number of Slices, ie samples to
		/// blend is computed from SlabThickness and SlabResolution).
		/// </summary>
		// Token: 0x0600D752 RID: 55122 RVA: 0x0012B480 File Offset: 0x00129680
		public virtual void SetSlabResolution(double _arg)
		{
			vtkImageSlabReslice.vtkImageSlabReslice_SetSlabResolution_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600D753 RID: 55123
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSlabReslice_SetSlabThickness_17(HandleRef pThis, double _arg);

		/// <summary>
		/// SlabThickness of slab in world coords. SlabThickness must be non-zero and
		/// positive.
		/// </summary>
		// Token: 0x0600D754 RID: 55124 RVA: 0x0012B490 File Offset: 0x00129690
		public virtual void SetSlabThickness(double _arg)
		{
			vtkImageSlabReslice.vtkImageSlabReslice_SetSlabThickness_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FC8 RID: 4040
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSlabReslice";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FC9 RID: 4041
		public new static readonly string MRClassNameKey = "class vtkImageSlabReslice";
	}
}
