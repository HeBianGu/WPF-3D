using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHyperStreamline
	/// </summary>
	/// <remarks>
	///    generate hyperstreamline in arbitrary dataset
	///
	/// vtkHyperStreamline is a filter that integrates through a tensor field to
	/// generate a hyperstreamline. The integration is along the maximum eigenvector
	/// and the cross section of the hyperstreamline is defined by the two other
	/// eigenvectors. Thus the shape of the hyperstreamline is "tube-like", with
	/// the cross section being elliptical. Hyperstreamlines are used to visualize
	/// tensor fields.
	///
	/// The starting point of a hyperstreamline can be defined in one of two ways.
	/// First, you may specify an initial position. This is a x-y-z global
	/// coordinate. The second option is to specify a starting location. This is
	/// cellId, subId, and cell parametric coordinates.
	///
	/// The integration of the hyperstreamline occurs through the major eigenvector
	/// field. IntegrationStepLength controls the step length within each cell
	/// (i.e., this is the fraction of the cell length). The length of the
	/// hyperstreamline is controlled by MaximumPropagationDistance. This parameter
	/// is the length of the hyperstreamline in units of distance. The tube itself
	/// is composed of many small sub-tubes - NumberOfSides controls the number of
	/// sides in the tube, and StepLength controls the length of the sub-tubes.
	///
	/// Because hyperstreamlines are often created near regions of singularities, it
	/// is possible to control the scaling of the tube cross section by using a
	/// logarithmic scale. Use LogScalingOn to turn this capability on. The Radius
	/// value controls the initial radius of the tube.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTensorGlyph
	/// </seealso>
	// Token: 0x020008AC RID: 2220
	public class vtkHyperStreamline : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016FE6 RID: 94182 RVA: 0x0020518F File Offset: 0x0020338F
		static vtkHyperStreamline()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperStreamline.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperStreamline"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016FE7 RID: 94183 RVA: 0x002051B7 File Offset: 0x002033B7
		public vtkHyperStreamline(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016FE8 RID: 94184
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperStreamline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with initial starting position (0,0,0); integration
		/// step length 0.2; step length 0.01; forward integration; terminal
		/// eigenvalue 0.0; number of sides 6; radius 0.5; and logarithmic scaling
		/// off.
		/// </summary>
		// Token: 0x06016FE9 RID: 94185 RVA: 0x002051C8 File Offset: 0x002033C8
		public new static vtkHyperStreamline New()
		{
			vtkHyperStreamline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperStreamline.vtkHyperStreamline_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperStreamline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with initial starting position (0,0,0); integration
		/// step length 0.2; step length 0.01; forward integration; terminal
		/// eigenvalue 0.0; number of sides 6; radius 0.5; and logarithmic scaling
		/// off.
		/// </summary>
		// Token: 0x06016FEA RID: 94186 RVA: 0x0020521C File Offset: 0x0020341C
		public vtkHyperStreamline() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHyperStreamline.vtkHyperStreamline_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016FEB RID: 94187 RVA: 0x00205260 File Offset: 0x00203460
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016FEC RID: 94188
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_GetIntegrationDirection_01(HandleRef pThis);

		/// <summary>
		/// Specify the direction in which to integrate the hyperstreamline.
		/// </summary>
		// Token: 0x06016FED RID: 94189 RVA: 0x0020526C File Offset: 0x0020346C
		public virtual int GetIntegrationDirection()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationDirection_01(base.GetCppThis());
		}

		// Token: 0x06016FEE RID: 94190
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_GetIntegrationDirectionMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Specify the direction in which to integrate the hyperstreamline.
		/// </summary>
		// Token: 0x06016FEF RID: 94191 RVA: 0x0020528C File Offset: 0x0020348C
		public virtual int GetIntegrationDirectionMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationDirectionMaxValue_02(base.GetCppThis());
		}

		// Token: 0x06016FF0 RID: 94192
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_GetIntegrationDirectionMinValue_03(HandleRef pThis);

		/// <summary>
		/// Specify the direction in which to integrate the hyperstreamline.
		/// </summary>
		// Token: 0x06016FF1 RID: 94193 RVA: 0x002052AC File Offset: 0x002034AC
		public virtual int GetIntegrationDirectionMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationDirectionMinValue_03(base.GetCppThis());
		}

		// Token: 0x06016FF2 RID: 94194
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_GetIntegrationEigenvector_04(HandleRef pThis);

		/// <summary>
		/// Set / get the eigenvector field through which to ingrate. It is
		/// possible to integrate using the major, medium or minor
		/// eigenvector field.  The major eigenvector is the eigenvector
		/// whose corresponding eigenvalue is closest to positive infinity.
		/// The minor eigenvector is the eigenvector whose corresponding
		/// eigenvalue is closest to negative infinity.  The medium
		/// eigenvector is the eigenvector whose corresponding eigenvalue is
		/// between the major and minor eigenvalues.
		/// </summary>
		// Token: 0x06016FF3 RID: 94195 RVA: 0x002052CC File Offset: 0x002034CC
		public virtual int GetIntegrationEigenvector()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationEigenvector_04(base.GetCppThis());
		}

		// Token: 0x06016FF4 RID: 94196
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_GetIntegrationEigenvectorMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set / get the eigenvector field through which to ingrate. It is
		/// possible to integrate using the major, medium or minor
		/// eigenvector field.  The major eigenvector is the eigenvector
		/// whose corresponding eigenvalue is closest to positive infinity.
		/// The minor eigenvector is the eigenvector whose corresponding
		/// eigenvalue is closest to negative infinity.  The medium
		/// eigenvector is the eigenvector whose corresponding eigenvalue is
		/// between the major and minor eigenvalues.
		/// </summary>
		// Token: 0x06016FF5 RID: 94197 RVA: 0x002052EC File Offset: 0x002034EC
		public virtual int GetIntegrationEigenvectorMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationEigenvectorMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06016FF6 RID: 94198
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_GetIntegrationEigenvectorMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set / get the eigenvector field through which to ingrate. It is
		/// possible to integrate using the major, medium or minor
		/// eigenvector field.  The major eigenvector is the eigenvector
		/// whose corresponding eigenvalue is closest to positive infinity.
		/// The minor eigenvector is the eigenvector whose corresponding
		/// eigenvalue is closest to negative infinity.  The medium
		/// eigenvector is the eigenvector whose corresponding eigenvalue is
		/// between the major and minor eigenvalues.
		/// </summary>
		// Token: 0x06016FF7 RID: 94199 RVA: 0x0020530C File Offset: 0x0020350C
		public virtual int GetIntegrationEigenvectorMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationEigenvectorMinValue_06(base.GetCppThis());
		}

		// Token: 0x06016FF8 RID: 94200
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetIntegrationStepLength_07(HandleRef pThis);

		/// <summary>
		/// Set / get a nominal integration step size (expressed as a fraction of
		/// the size of each cell).
		/// </summary>
		// Token: 0x06016FF9 RID: 94201 RVA: 0x0020532C File Offset: 0x0020352C
		public virtual double GetIntegrationStepLength()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationStepLength_07(base.GetCppThis());
		}

		// Token: 0x06016FFA RID: 94202
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetIntegrationStepLengthMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set / get a nominal integration step size (expressed as a fraction of
		/// the size of each cell).
		/// </summary>
		// Token: 0x06016FFB RID: 94203 RVA: 0x0020534C File Offset: 0x0020354C
		public virtual double GetIntegrationStepLengthMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationStepLengthMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06016FFC RID: 94204
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetIntegrationStepLengthMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set / get a nominal integration step size (expressed as a fraction of
		/// the size of each cell).
		/// </summary>
		// Token: 0x06016FFD RID: 94205 RVA: 0x0020536C File Offset: 0x0020356C
		public virtual double GetIntegrationStepLengthMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetIntegrationStepLengthMinValue_09(base.GetCppThis());
		}

		// Token: 0x06016FFE RID: 94206
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_GetLogScaling_10(HandleRef pThis);

		/// <summary>
		/// Turn on/off logarithmic scaling. If scaling is on, the log base 10
		/// of the computed eigenvalues are used to scale the cross section radii.
		/// </summary>
		// Token: 0x06016FFF RID: 94207 RVA: 0x0020538C File Offset: 0x0020358C
		public virtual int GetLogScaling()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetLogScaling_10(base.GetCppThis());
		}

		// Token: 0x06017000 RID: 94208
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetMaximumPropagationDistance_11(HandleRef pThis);

		/// <summary>
		/// Set / get the maximum length of the hyperstreamline expressed as absolute
		/// distance (i.e., arc length) value.
		/// </summary>
		// Token: 0x06017001 RID: 94209 RVA: 0x002053AC File Offset: 0x002035AC
		public virtual double GetMaximumPropagationDistance()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetMaximumPropagationDistance_11(base.GetCppThis());
		}

		// Token: 0x06017002 RID: 94210
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetMaximumPropagationDistanceMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Set / get the maximum length of the hyperstreamline expressed as absolute
		/// distance (i.e., arc length) value.
		/// </summary>
		// Token: 0x06017003 RID: 94211 RVA: 0x002053CC File Offset: 0x002035CC
		public virtual double GetMaximumPropagationDistanceMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetMaximumPropagationDistanceMaxValue_12(base.GetCppThis());
		}

		// Token: 0x06017004 RID: 94212
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetMaximumPropagationDistanceMinValue_13(HandleRef pThis);

		/// <summary>
		/// Set / get the maximum length of the hyperstreamline expressed as absolute
		/// distance (i.e., arc length) value.
		/// </summary>
		// Token: 0x06017005 RID: 94213 RVA: 0x002053EC File Offset: 0x002035EC
		public virtual double GetMaximumPropagationDistanceMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetMaximumPropagationDistanceMinValue_13(base.GetCppThis());
		}

		// Token: 0x06017006 RID: 94214
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperStreamline_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017007 RID: 94215 RVA: 0x0020540C File Offset: 0x0020360C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06017008 RID: 94216
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperStreamline_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017009 RID: 94217 RVA: 0x0020542C File Offset: 0x0020362C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x0601700A RID: 94218
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_GetNumberOfSides_16(HandleRef pThis);

		/// <summary>
		/// Set / get the number of sides for the hyperstreamlines. At a minimum,
		/// number of sides is 3.
		/// </summary>
		// Token: 0x0601700B RID: 94219 RVA: 0x00205448 File Offset: 0x00203648
		public virtual int GetNumberOfSides()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetNumberOfSides_16(base.GetCppThis());
		}

		// Token: 0x0601700C RID: 94220
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_GetNumberOfSidesMaxValue_17(HandleRef pThis);

		/// <summary>
		/// Set / get the number of sides for the hyperstreamlines. At a minimum,
		/// number of sides is 3.
		/// </summary>
		// Token: 0x0601700D RID: 94221 RVA: 0x00205468 File Offset: 0x00203668
		public virtual int GetNumberOfSidesMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetNumberOfSidesMaxValue_17(base.GetCppThis());
		}

		// Token: 0x0601700E RID: 94222
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_GetNumberOfSidesMinValue_18(HandleRef pThis);

		/// <summary>
		/// Set / get the number of sides for the hyperstreamlines. At a minimum,
		/// number of sides is 3.
		/// </summary>
		// Token: 0x0601700F RID: 94223 RVA: 0x00205488 File Offset: 0x00203688
		public virtual int GetNumberOfSidesMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetNumberOfSidesMinValue_18(base.GetCppThis());
		}

		// Token: 0x06017010 RID: 94224
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetRadius_19(HandleRef pThis);

		/// <summary>
		/// Set / get the initial tube radius. This is the maximum "elliptical"
		/// radius at the beginning of the tube. Radius varies based on ratio of
		/// eigenvalues.  Note that tube section is actually elliptical and may
		/// become a point or line in cross section in some cases.
		/// </summary>
		// Token: 0x06017011 RID: 94225 RVA: 0x002054A8 File Offset: 0x002036A8
		public virtual double GetRadius()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetRadius_19(base.GetCppThis());
		}

		// Token: 0x06017012 RID: 94226
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetRadiusMaxValue_20(HandleRef pThis);

		/// <summary>
		/// Set / get the initial tube radius. This is the maximum "elliptical"
		/// radius at the beginning of the tube. Radius varies based on ratio of
		/// eigenvalues.  Note that tube section is actually elliptical and may
		/// become a point or line in cross section in some cases.
		/// </summary>
		// Token: 0x06017013 RID: 94227 RVA: 0x002054C8 File Offset: 0x002036C8
		public virtual double GetRadiusMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetRadiusMaxValue_20(base.GetCppThis());
		}

		// Token: 0x06017014 RID: 94228
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetRadiusMinValue_21(HandleRef pThis);

		/// <summary>
		/// Set / get the initial tube radius. This is the maximum "elliptical"
		/// radius at the beginning of the tube. Radius varies based on ratio of
		/// eigenvalues.  Note that tube section is actually elliptical and may
		/// become a point or line in cross section in some cases.
		/// </summary>
		// Token: 0x06017015 RID: 94229 RVA: 0x002054E8 File Offset: 0x002036E8
		public virtual double GetRadiusMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetRadiusMinValue_21(base.GetCppThis());
		}

		// Token: 0x06017016 RID: 94230
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHyperStreamline_GetStartLocation_22(HandleRef pThis, ref int subId, IntPtr pcoords);

		/// <summary>
		/// Get the starting location of the hyperstreamline in the cell coordinate
		/// system. Returns the cell that the starting point is in.
		/// </summary>
		// Token: 0x06017017 RID: 94231 RVA: 0x00205508 File Offset: 0x00203708
		public long GetStartLocation(ref int subId, IntPtr pcoords)
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetStartLocation_22(base.GetCppThis(), ref subId, pcoords);
		}

		// Token: 0x06017018 RID: 94232
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperStreamline_GetStartPosition_23(HandleRef pThis);

		/// <summary>
		/// Get the start position of the hyperstreamline in global x-y-z coordinates.
		/// </summary>
		// Token: 0x06017019 RID: 94233 RVA: 0x0020552C File Offset: 0x0020372C
		public double[] GetStartPosition()
		{
			IntPtr intPtr = vtkHyperStreamline.vtkHyperStreamline_GetStartPosition_23(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601701A RID: 94234
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetStepLength_24(HandleRef pThis);

		/// <summary>
		/// Set / get the length of a tube segment composing the
		/// hyperstreamline. The length is specified as a fraction of the
		/// diagonal length of the input bounding box.
		/// </summary>
		// Token: 0x0601701B RID: 94235 RVA: 0x00205574 File Offset: 0x00203774
		public virtual double GetStepLength()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetStepLength_24(base.GetCppThis());
		}

		// Token: 0x0601701C RID: 94236
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetStepLengthMaxValue_25(HandleRef pThis);

		/// <summary>
		/// Set / get the length of a tube segment composing the
		/// hyperstreamline. The length is specified as a fraction of the
		/// diagonal length of the input bounding box.
		/// </summary>
		// Token: 0x0601701D RID: 94237 RVA: 0x00205594 File Offset: 0x00203794
		public virtual double GetStepLengthMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetStepLengthMaxValue_25(base.GetCppThis());
		}

		// Token: 0x0601701E RID: 94238
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetStepLengthMinValue_26(HandleRef pThis);

		/// <summary>
		/// Set / get the length of a tube segment composing the
		/// hyperstreamline. The length is specified as a fraction of the
		/// diagonal length of the input bounding box.
		/// </summary>
		// Token: 0x0601701F RID: 94239 RVA: 0x002055B4 File Offset: 0x002037B4
		public virtual double GetStepLengthMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetStepLengthMinValue_26(base.GetCppThis());
		}

		// Token: 0x06017020 RID: 94240
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetTerminalEigenvalue_27(HandleRef pThis);

		/// <summary>
		/// Set/get terminal eigenvalue.  If major eigenvalue falls below this
		/// value, hyperstreamline terminates propagation.
		/// </summary>
		// Token: 0x06017021 RID: 94241 RVA: 0x002055D4 File Offset: 0x002037D4
		public virtual double GetTerminalEigenvalue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetTerminalEigenvalue_27(base.GetCppThis());
		}

		// Token: 0x06017022 RID: 94242
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetTerminalEigenvalueMaxValue_28(HandleRef pThis);

		/// <summary>
		/// Set/get terminal eigenvalue.  If major eigenvalue falls below this
		/// value, hyperstreamline terminates propagation.
		/// </summary>
		// Token: 0x06017023 RID: 94243 RVA: 0x002055F4 File Offset: 0x002037F4
		public virtual double GetTerminalEigenvalueMaxValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetTerminalEigenvalueMaxValue_28(base.GetCppThis());
		}

		// Token: 0x06017024 RID: 94244
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHyperStreamline_GetTerminalEigenvalueMinValue_29(HandleRef pThis);

		/// <summary>
		/// Set/get terminal eigenvalue.  If major eigenvalue falls below this
		/// value, hyperstreamline terminates propagation.
		/// </summary>
		// Token: 0x06017025 RID: 94245 RVA: 0x00205614 File Offset: 0x00203814
		public virtual double GetTerminalEigenvalueMinValue()
		{
			return vtkHyperStreamline.vtkHyperStreamline_GetTerminalEigenvalueMinValue_29(base.GetCppThis());
		}

		// Token: 0x06017026 RID: 94246
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_IntegrateMajorEigenvector_30(HandleRef pThis);

		/// <summary>
		/// Use the major eigenvector field as the vector field through which
		/// to integrate.  The major eigenvector is the eigenvector whose
		/// corresponding eigenvalue is closest to positive infinity.
		/// </summary>
		// Token: 0x06017027 RID: 94247 RVA: 0x00205633 File Offset: 0x00203833
		public void IntegrateMajorEigenvector()
		{
			vtkHyperStreamline.vtkHyperStreamline_IntegrateMajorEigenvector_30(base.GetCppThis());
		}

		// Token: 0x06017028 RID: 94248
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_IntegrateMediumEigenvector_31(HandleRef pThis);

		/// <summary>
		/// Use the medium eigenvector field as the vector field through which
		/// to integrate. The medium eigenvector is the eigenvector whose
		/// corresponding eigenvalue is between the major and minor
		/// eigenvalues.
		/// </summary>
		// Token: 0x06017029 RID: 94249 RVA: 0x00205642 File Offset: 0x00203842
		public void IntegrateMediumEigenvector()
		{
			vtkHyperStreamline.vtkHyperStreamline_IntegrateMediumEigenvector_31(base.GetCppThis());
		}

		// Token: 0x0601702A RID: 94250
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_IntegrateMinorEigenvector_32(HandleRef pThis);

		/// <summary>
		/// Use the minor eigenvector field as the vector field through which
		/// to integrate. The minor eigenvector is the eigenvector whose
		/// corresponding eigenvalue is closest to negative infinity.
		/// </summary>
		// Token: 0x0601702B RID: 94251 RVA: 0x00205651 File Offset: 0x00203851
		public void IntegrateMinorEigenvector()
		{
			vtkHyperStreamline.vtkHyperStreamline_IntegrateMinorEigenvector_32(base.GetCppThis());
		}

		// Token: 0x0601702C RID: 94252
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_IsA_33(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601702D RID: 94253 RVA: 0x00205660 File Offset: 0x00203860
		public override int IsA(string type)
		{
			return vtkHyperStreamline.vtkHyperStreamline_IsA_33(base.GetCppThis(), type);
		}

		// Token: 0x0601702E RID: 94254
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHyperStreamline_IsTypeOf_34([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601702F RID: 94255 RVA: 0x00205680 File Offset: 0x00203880
		public new static int IsTypeOf(string type)
		{
			return vtkHyperStreamline.vtkHyperStreamline_IsTypeOf_34(type);
		}

		// Token: 0x06017030 RID: 94256
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_LogScalingOff_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off logarithmic scaling. If scaling is on, the log base 10
		/// of the computed eigenvalues are used to scale the cross section radii.
		/// </summary>
		// Token: 0x06017031 RID: 94257 RVA: 0x0020569A File Offset: 0x0020389A
		public virtual void LogScalingOff()
		{
			vtkHyperStreamline.vtkHyperStreamline_LogScalingOff_35(base.GetCppThis());
		}

		// Token: 0x06017032 RID: 94258
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_LogScalingOn_36(HandleRef pThis);

		/// <summary>
		/// Turn on/off logarithmic scaling. If scaling is on, the log base 10
		/// of the computed eigenvalues are used to scale the cross section radii.
		/// </summary>
		// Token: 0x06017033 RID: 94259 RVA: 0x002056A9 File Offset: 0x002038A9
		public virtual void LogScalingOn()
		{
			vtkHyperStreamline.vtkHyperStreamline_LogScalingOn_36(base.GetCppThis());
		}

		// Token: 0x06017034 RID: 94260
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperStreamline_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017035 RID: 94261 RVA: 0x002056B8 File Offset: 0x002038B8
		public new vtkHyperStreamline NewInstance()
		{
			vtkHyperStreamline result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperStreamline.vtkHyperStreamline_NewInstance_38(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperStreamline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017036 RID: 94262
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHyperStreamline_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017037 RID: 94263 RVA: 0x00205714 File Offset: 0x00203914
		public new static vtkHyperStreamline SafeDownCast(vtkObjectBase o)
		{
			vtkHyperStreamline vtkHyperStreamline = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHyperStreamline.vtkHyperStreamline_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperStreamline = (vtkHyperStreamline)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperStreamline.Register(null);
				}
			}
			return vtkHyperStreamline;
		}

		// Token: 0x06017038 RID: 94264
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetIntegrationDirection_40(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the direction in which to integrate the hyperstreamline.
		/// </summary>
		// Token: 0x06017039 RID: 94265 RVA: 0x00205793 File Offset: 0x00203993
		public virtual void SetIntegrationDirection(int _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationDirection_40(base.GetCppThis(), _arg);
		}

		// Token: 0x0601703A RID: 94266
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetIntegrationDirectionToBackward_41(HandleRef pThis);

		/// <summary>
		/// Specify the direction in which to integrate the hyperstreamline.
		/// </summary>
		// Token: 0x0601703B RID: 94267 RVA: 0x002057A3 File Offset: 0x002039A3
		public void SetIntegrationDirectionToBackward()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationDirectionToBackward_41(base.GetCppThis());
		}

		// Token: 0x0601703C RID: 94268
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetIntegrationDirectionToForward_42(HandleRef pThis);

		/// <summary>
		/// Specify the direction in which to integrate the hyperstreamline.
		/// </summary>
		// Token: 0x0601703D RID: 94269 RVA: 0x002057B2 File Offset: 0x002039B2
		public void SetIntegrationDirectionToForward()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationDirectionToForward_42(base.GetCppThis());
		}

		// Token: 0x0601703E RID: 94270
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetIntegrationDirectionToIntegrateBothDirections_43(HandleRef pThis);

		/// <summary>
		/// Specify the direction in which to integrate the hyperstreamline.
		/// </summary>
		// Token: 0x0601703F RID: 94271 RVA: 0x002057C1 File Offset: 0x002039C1
		public void SetIntegrationDirectionToIntegrateBothDirections()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationDirectionToIntegrateBothDirections_43(base.GetCppThis());
		}

		// Token: 0x06017040 RID: 94272
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetIntegrationEigenvector_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / get the eigenvector field through which to ingrate. It is
		/// possible to integrate using the major, medium or minor
		/// eigenvector field.  The major eigenvector is the eigenvector
		/// whose corresponding eigenvalue is closest to positive infinity.
		/// The minor eigenvector is the eigenvector whose corresponding
		/// eigenvalue is closest to negative infinity.  The medium
		/// eigenvector is the eigenvector whose corresponding eigenvalue is
		/// between the major and minor eigenvalues.
		/// </summary>
		// Token: 0x06017041 RID: 94273 RVA: 0x002057D0 File Offset: 0x002039D0
		public virtual void SetIntegrationEigenvector(int _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationEigenvector_44(base.GetCppThis(), _arg);
		}

		// Token: 0x06017042 RID: 94274
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetIntegrationEigenvectorToMajor_45(HandleRef pThis);

		/// <summary>
		/// Set / get the eigenvector field through which to ingrate. It is
		/// possible to integrate using the major, medium or minor
		/// eigenvector field.  The major eigenvector is the eigenvector
		/// whose corresponding eigenvalue is closest to positive infinity.
		/// The minor eigenvector is the eigenvector whose corresponding
		/// eigenvalue is closest to negative infinity.  The medium
		/// eigenvector is the eigenvector whose corresponding eigenvalue is
		/// between the major and minor eigenvalues.
		/// </summary>
		// Token: 0x06017043 RID: 94275 RVA: 0x002057E0 File Offset: 0x002039E0
		public void SetIntegrationEigenvectorToMajor()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationEigenvectorToMajor_45(base.GetCppThis());
		}

		// Token: 0x06017044 RID: 94276
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetIntegrationEigenvectorToMedium_46(HandleRef pThis);

		/// <summary>
		/// Set / get the eigenvector field through which to ingrate. It is
		/// possible to integrate using the major, medium or minor
		/// eigenvector field.  The major eigenvector is the eigenvector
		/// whose corresponding eigenvalue is closest to positive infinity.
		/// The minor eigenvector is the eigenvector whose corresponding
		/// eigenvalue is closest to negative infinity.  The medium
		/// eigenvector is the eigenvector whose corresponding eigenvalue is
		/// between the major and minor eigenvalues.
		/// </summary>
		// Token: 0x06017045 RID: 94277 RVA: 0x002057EF File Offset: 0x002039EF
		public void SetIntegrationEigenvectorToMedium()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationEigenvectorToMedium_46(base.GetCppThis());
		}

		// Token: 0x06017046 RID: 94278
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetIntegrationEigenvectorToMinor_47(HandleRef pThis);

		/// <summary>
		/// Set / get the eigenvector field through which to ingrate. It is
		/// possible to integrate using the major, medium or minor
		/// eigenvector field.  The major eigenvector is the eigenvector
		/// whose corresponding eigenvalue is closest to positive infinity.
		/// The minor eigenvector is the eigenvector whose corresponding
		/// eigenvalue is closest to negative infinity.  The medium
		/// eigenvector is the eigenvector whose corresponding eigenvalue is
		/// between the major and minor eigenvalues.
		/// </summary>
		// Token: 0x06017047 RID: 94279 RVA: 0x002057FE File Offset: 0x002039FE
		public void SetIntegrationEigenvectorToMinor()
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationEigenvectorToMinor_47(base.GetCppThis());
		}

		// Token: 0x06017048 RID: 94280
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetIntegrationStepLength_48(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get a nominal integration step size (expressed as a fraction of
		/// the size of each cell).
		/// </summary>
		// Token: 0x06017049 RID: 94281 RVA: 0x0020580D File Offset: 0x00203A0D
		public virtual void SetIntegrationStepLength(double _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetIntegrationStepLength_48(base.GetCppThis(), _arg);
		}

		// Token: 0x0601704A RID: 94282
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetLogScaling_49(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off logarithmic scaling. If scaling is on, the log base 10
		/// of the computed eigenvalues are used to scale the cross section radii.
		/// </summary>
		// Token: 0x0601704B RID: 94283 RVA: 0x0020581D File Offset: 0x00203A1D
		public virtual void SetLogScaling(int _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetLogScaling_49(base.GetCppThis(), _arg);
		}

		// Token: 0x0601704C RID: 94284
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetMaximumPropagationDistance_50(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the maximum length of the hyperstreamline expressed as absolute
		/// distance (i.e., arc length) value.
		/// </summary>
		// Token: 0x0601704D RID: 94285 RVA: 0x0020582D File Offset: 0x00203A2D
		public virtual void SetMaximumPropagationDistance(double _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetMaximumPropagationDistance_50(base.GetCppThis(), _arg);
		}

		// Token: 0x0601704E RID: 94286
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetNumberOfSides_51(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / get the number of sides for the hyperstreamlines. At a minimum,
		/// number of sides is 3.
		/// </summary>
		// Token: 0x0601704F RID: 94287 RVA: 0x0020583D File Offset: 0x00203A3D
		public virtual void SetNumberOfSides(int _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetNumberOfSides_51(base.GetCppThis(), _arg);
		}

		// Token: 0x06017050 RID: 94288
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetRadius_52(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the initial tube radius. This is the maximum "elliptical"
		/// radius at the beginning of the tube. Radius varies based on ratio of
		/// eigenvalues.  Note that tube section is actually elliptical and may
		/// become a point or line in cross section in some cases.
		/// </summary>
		// Token: 0x06017051 RID: 94289 RVA: 0x0020584D File Offset: 0x00203A4D
		public virtual void SetRadius(double _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetRadius_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06017052 RID: 94290
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetStartLocation_53(HandleRef pThis, long cellId, int subId, IntPtr pcoords);

		/// <summary>
		/// Specify the start of the hyperstreamline in the cell coordinate system.
		/// That is, cellId and subId (if composite cell), and parametric coordinates.
		/// </summary>
		// Token: 0x06017053 RID: 94291 RVA: 0x0020585D File Offset: 0x00203A5D
		public void SetStartLocation(long cellId, int subId, IntPtr pcoords)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetStartLocation_53(base.GetCppThis(), cellId, subId, pcoords);
		}

		// Token: 0x06017054 RID: 94292
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetStartLocation_54(HandleRef pThis, long cellId, int subId, double r, double s, double t);

		/// <summary>
		/// Specify the start of the hyperstreamline in the cell coordinate system.
		/// That is, cellId and subId (if composite cell), and parametric coordinates.
		/// </summary>
		// Token: 0x06017055 RID: 94293 RVA: 0x0020586F File Offset: 0x00203A6F
		public void SetStartLocation(long cellId, int subId, double r, double s, double t)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetStartLocation_54(base.GetCppThis(), cellId, subId, r, s, t);
		}

		// Token: 0x06017056 RID: 94294
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetStartPosition_55(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Specify the start of the hyperstreamline in the global coordinate system.
		/// Starting from position implies that a search must be performed to find
		/// initial cell to start integration from.
		/// </summary>
		// Token: 0x06017057 RID: 94295 RVA: 0x00205885 File Offset: 0x00203A85
		public void SetStartPosition(IntPtr x)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetStartPosition_55(base.GetCppThis(), x);
		}

		// Token: 0x06017058 RID: 94296
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetStartPosition_56(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Specify the start of the hyperstreamline in the global coordinate system.
		/// Starting from position implies that a search must be performed to find
		/// initial cell to start integration from.
		/// </summary>
		// Token: 0x06017059 RID: 94297 RVA: 0x00205895 File Offset: 0x00203A95
		public void SetStartPosition(double x, double y, double z)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetStartPosition_56(base.GetCppThis(), x, y, z);
		}

		// Token: 0x0601705A RID: 94298
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetStepLength_57(HandleRef pThis, double _arg);

		/// <summary>
		/// Set / get the length of a tube segment composing the
		/// hyperstreamline. The length is specified as a fraction of the
		/// diagonal length of the input bounding box.
		/// </summary>
		// Token: 0x0601705B RID: 94299 RVA: 0x002058A7 File Offset: 0x00203AA7
		public virtual void SetStepLength(double _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetStepLength_57(base.GetCppThis(), _arg);
		}

		// Token: 0x0601705C RID: 94300
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHyperStreamline_SetTerminalEigenvalue_58(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get terminal eigenvalue.  If major eigenvalue falls below this
		/// value, hyperstreamline terminates propagation.
		/// </summary>
		// Token: 0x0601705D RID: 94301 RVA: 0x002058B7 File Offset: 0x00203AB7
		public virtual void SetTerminalEigenvalue(double _arg)
		{
			vtkHyperStreamline.vtkHyperStreamline_SetTerminalEigenvalue_58(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019BE RID: 6590
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperStreamline";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019BF RID: 6591
		public new static readonly string MRClassNameKey = "class vtkHyperStreamline";
	}
}
