using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClipClosedSurface
	/// </summary>
	/// <remarks>
	///    Clip a closed surface with a plane collection
	///
	/// vtkClipClosedSurface will clip a closed polydata surface with a
	/// collection of clipping planes.  It will produce a new closed surface
	/// by creating new polygonal faces where the input data was clipped.
	///
	/// Non-manifold surfaces should not be used as input for this filter.
	/// The input surface should have no open edges, and must not have any
	/// edges that are shared by more than two faces.  The vtkFeatureEdges
	/// filter can be used to verify that a data set satisfies these conditions.
	/// In addition, the input surface should not self-intersect, meaning
	/// that the faces of the surface should only touch at their edges.
	///
	/// If GenerateOutline is on, this filter will generate an outline wherever
	/// the clipping planes intersect the data.  The ScalarMode option
	/// will add cell scalars to the output, so that the generated faces
	/// can be visualized in a different color from the original surface.
	///
	/// @warning
	/// The triangulation of new faces is done in O(n) time for simple convex
	/// inputs, but for non-convex inputs the worst-case time is O(n^2*m^2)
	/// where n is the number of points and m is the number of 3D cavities.
	/// The best triangulation algorithms, in contrast, are O(n log n).
	/// There are also rare cases where the triangulation will fail to produce
	/// a watertight output.  Turn on TriangulationErrorDisplay to be notified
	/// of these failures.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkOutlineFilter vtkOutlineSource vtkVolumeOutlineSource
	/// vtkContourTriangulator
	///
	/// @par Thanks:
	/// Thanks to David Gobbi for contributing this class to VTK.
	/// </seealso>
	// Token: 0x02000881 RID: 2177
	public class vtkClipClosedSurface : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016956 RID: 92502 RVA: 0x001FC6D7 File Offset: 0x001FA8D7
		static vtkClipClosedSurface()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipClosedSurface.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipClosedSurface"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016957 RID: 92503 RVA: 0x001FC6FF File Offset: 0x001FA8FF
		public vtkClipClosedSurface(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016958 RID: 92504
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipClosedSurface_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016959 RID: 92505 RVA: 0x001FC710 File Offset: 0x001FA910
		public new static vtkClipClosedSurface New()
		{
			vtkClipClosedSurface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipClosedSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0601695A RID: 92506 RVA: 0x001FC764 File Offset: 0x001FA964
		public vtkClipClosedSurface() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClipClosedSurface.vtkClipClosedSurface_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601695B RID: 92507 RVA: 0x001FC7A8 File Offset: 0x001FA9A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601695C RID: 92508
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_GenerateFacesOff_01(HandleRef pThis);

		/// <summary>
		/// Set whether to generate polygonal faces for the output.  This is
		/// on by default.  If it is off, then the output will have no polys.
		/// </summary>
		// Token: 0x0601695D RID: 92509 RVA: 0x001FC7B3 File Offset: 0x001FA9B3
		public virtual void GenerateFacesOff()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GenerateFacesOff_01(base.GetCppThis());
		}

		// Token: 0x0601695E RID: 92510
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_GenerateFacesOn_02(HandleRef pThis);

		/// <summary>
		/// Set whether to generate polygonal faces for the output.  This is
		/// on by default.  If it is off, then the output will have no polys.
		/// </summary>
		// Token: 0x0601695F RID: 92511 RVA: 0x001FC7C2 File Offset: 0x001FA9C2
		public virtual void GenerateFacesOn()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GenerateFacesOn_02(base.GetCppThis());
		}

		// Token: 0x06016960 RID: 92512
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_GenerateOutlineOff_03(HandleRef pThis);

		/// <summary>
		/// Set whether to generate an outline wherever an input face was
		/// cut by a plane.  This is off by default.
		/// </summary>
		// Token: 0x06016961 RID: 92513 RVA: 0x001FC7D1 File Offset: 0x001FA9D1
		public virtual void GenerateOutlineOff()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GenerateOutlineOff_03(base.GetCppThis());
		}

		// Token: 0x06016962 RID: 92514
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_GenerateOutlineOn_04(HandleRef pThis);

		/// <summary>
		/// Set whether to generate an outline wherever an input face was
		/// cut by a plane.  This is off by default.
		/// </summary>
		// Token: 0x06016963 RID: 92515 RVA: 0x001FC7E0 File Offset: 0x001FA9E0
		public virtual void GenerateOutlineOn()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GenerateOutlineOn_04(base.GetCppThis());
		}

		// Token: 0x06016964 RID: 92516
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipClosedSurface_GetActivePlaneColor_05(HandleRef pThis);

		/// <summary>
		/// Set the color for any new geometry produced by clipping with the
		/// ActivePlane, if ActivePlaneId is set.  Default is yellow.
		/// Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x06016965 RID: 92517 RVA: 0x001FC7F0 File Offset: 0x001FA9F0
		public virtual double[] GetActivePlaneColor()
		{
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_GetActivePlaneColor_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016966 RID: 92518
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_GetActivePlaneColor_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the color for any new geometry produced by clipping with the
		/// ActivePlane, if ActivePlaneId is set.  Default is yellow.
		/// Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x06016967 RID: 92519 RVA: 0x001FC838 File Offset: 0x001FAA38
		public virtual void GetActivePlaneColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetActivePlaneColor_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06016968 RID: 92520
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_GetActivePlaneColor_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color for any new geometry produced by clipping with the
		/// ActivePlane, if ActivePlaneId is set.  Default is yellow.
		/// Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x06016969 RID: 92521 RVA: 0x001FC84A File Offset: 0x001FAA4A
		public virtual void GetActivePlaneColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetActivePlaneColor_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0601696A RID: 92522
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipClosedSurface_GetActivePlaneId_08(HandleRef pThis);

		/// <summary>
		/// Set the active plane, so that the clipping from that plane can be
		/// displayed in a different color.  Set this to -1 if there is no active
		/// plane.  The default value is -1.
		/// </summary>
		// Token: 0x0601696B RID: 92523 RVA: 0x001FC85C File Offset: 0x001FAA5C
		public virtual int GetActivePlaneId()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetActivePlaneId_08(base.GetCppThis());
		}

		// Token: 0x0601696C RID: 92524
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipClosedSurface_GetBaseColor_09(HandleRef pThis);

		/// <summary>
		/// Set the color for all cells were part of the original geometry.
		/// If the input data already has color cell scalars, then those
		/// values will be used and parameter will be ignored.  The default color
		/// is red.  Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x0601696D RID: 92525 RVA: 0x001FC87C File Offset: 0x001FAA7C
		public virtual double[] GetBaseColor()
		{
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_GetBaseColor_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601696E RID: 92526
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_GetBaseColor_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the color for all cells were part of the original geometry.
		/// If the input data already has color cell scalars, then those
		/// values will be used and parameter will be ignored.  The default color
		/// is red.  Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x0601696F RID: 92527 RVA: 0x001FC8C4 File Offset: 0x001FAAC4
		public virtual void GetBaseColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetBaseColor_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06016970 RID: 92528
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_GetBaseColor_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color for all cells were part of the original geometry.
		/// If the input data already has color cell scalars, then those
		/// values will be used and parameter will be ignored.  The default color
		/// is red.  Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x06016971 RID: 92529 RVA: 0x001FC8D6 File Offset: 0x001FAAD6
		public virtual void GetBaseColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetBaseColor_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06016972 RID: 92530
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipClosedSurface_GetClipColor_12(HandleRef pThis);

		/// <summary>
		/// Set the color for any new geometry, either faces or outlines, that are
		/// created as a result of the clipping. The default color is orange.
		/// Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x06016973 RID: 92531 RVA: 0x001FC8E8 File Offset: 0x001FAAE8
		public virtual double[] GetClipColor()
		{
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_GetClipColor_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016974 RID: 92532
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_GetClipColor_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set the color for any new geometry, either faces or outlines, that are
		/// created as a result of the clipping. The default color is orange.
		/// Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x06016975 RID: 92533 RVA: 0x001FC930 File Offset: 0x001FAB30
		public virtual void GetClipColor(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetClipColor_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06016976 RID: 92534
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_GetClipColor_14(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color for any new geometry, either faces or outlines, that are
		/// created as a result of the clipping. The default color is orange.
		/// Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x06016977 RID: 92535 RVA: 0x001FC942 File Offset: 0x001FAB42
		public virtual void GetClipColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_GetClipColor_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06016978 RID: 92536
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipClosedSurface_GetClippingPlanes_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the vtkPlaneCollection that holds the clipping planes.
		/// </summary>
		// Token: 0x06016979 RID: 92537 RVA: 0x001FC954 File Offset: 0x001FAB54
		public virtual vtkPlaneCollection GetClippingPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_GetClippingPlanes_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		// Token: 0x0601697A RID: 92538
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipClosedSurface_GetGenerateFaces_16(HandleRef pThis);

		/// <summary>
		/// Set whether to generate polygonal faces for the output.  This is
		/// on by default.  If it is off, then the output will have no polys.
		/// </summary>
		// Token: 0x0601697B RID: 92539 RVA: 0x001FC9C4 File Offset: 0x001FABC4
		public virtual int GetGenerateFaces()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetGenerateFaces_16(base.GetCppThis());
		}

		// Token: 0x0601697C RID: 92540
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipClosedSurface_GetGenerateOutline_17(HandleRef pThis);

		/// <summary>
		/// Set whether to generate an outline wherever an input face was
		/// cut by a plane.  This is off by default.
		/// </summary>
		// Token: 0x0601697D RID: 92541 RVA: 0x001FC9E4 File Offset: 0x001FABE4
		public virtual int GetGenerateOutline()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetGenerateOutline_17(base.GetCppThis());
		}

		// Token: 0x0601697E RID: 92542
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClipClosedSurface_GetNumberOfGenerationsFromBase_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0601697F RID: 92543 RVA: 0x001FCA04 File Offset: 0x001FAC04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetNumberOfGenerationsFromBase_18(base.GetCppThis(), type);
		}

		// Token: 0x06016980 RID: 92544
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClipClosedSurface_GetNumberOfGenerationsFromBaseType_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016981 RID: 92545 RVA: 0x001FCA24 File Offset: 0x001FAC24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetNumberOfGenerationsFromBaseType_19(type);
		}

		// Token: 0x06016982 RID: 92546
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipClosedSurface_GetPassPointData_20(HandleRef pThis);

		/// <summary>
		/// Pass the point data to the output.  Point data will be interpolated
		/// when new points are generated.  This is off by default.
		/// </summary>
		// Token: 0x06016983 RID: 92547 RVA: 0x001FCA40 File Offset: 0x001FAC40
		public virtual int GetPassPointData()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetPassPointData_20(base.GetCppThis());
		}

		// Token: 0x06016984 RID: 92548
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipClosedSurface_GetScalarMode_21(HandleRef pThis);

		/// <summary>
		/// Set whether to add cell scalars, so that new faces and outlines
		/// can be distinguished from original faces and lines.  The options
		/// are "None", "Colors", and "Labels".  For the "Labels" option,
		/// a scalar value of "0" indicates an original cell, "1" indicates
		/// a new cell on a cut face, and "2" indicates a new cell on the
		/// ActivePlane as set by the SetActivePlane() method.  The default
		/// scalar mode is "None".
		/// </summary>
		// Token: 0x06016985 RID: 92549 RVA: 0x001FCA60 File Offset: 0x001FAC60
		public virtual int GetScalarMode()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetScalarMode_21(base.GetCppThis());
		}

		// Token: 0x06016986 RID: 92550
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipClosedSurface_GetScalarModeAsString_22(HandleRef pThis);

		/// <summary>
		/// Set whether to add cell scalars, so that new faces and outlines
		/// can be distinguished from original faces and lines.  The options
		/// are "None", "Colors", and "Labels".  For the "Labels" option,
		/// a scalar value of "0" indicates an original cell, "1" indicates
		/// a new cell on a cut face, and "2" indicates a new cell on the
		/// ActivePlane as set by the SetActivePlane() method.  The default
		/// scalar mode is "None".
		/// </summary>
		// Token: 0x06016987 RID: 92551 RVA: 0x001FCA80 File Offset: 0x001FAC80
		public string GetScalarModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkClipClosedSurface.vtkClipClosedSurface_GetScalarModeAsString_22(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016988 RID: 92552
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipClosedSurface_GetScalarModeMaxValue_23(HandleRef pThis);

		/// <summary>
		/// Set whether to add cell scalars, so that new faces and outlines
		/// can be distinguished from original faces and lines.  The options
		/// are "None", "Colors", and "Labels".  For the "Labels" option,
		/// a scalar value of "0" indicates an original cell, "1" indicates
		/// a new cell on a cut face, and "2" indicates a new cell on the
		/// ActivePlane as set by the SetActivePlane() method.  The default
		/// scalar mode is "None".
		/// </summary>
		// Token: 0x06016989 RID: 92553 RVA: 0x001FCABC File Offset: 0x001FACBC
		public virtual int GetScalarModeMaxValue()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetScalarModeMaxValue_23(base.GetCppThis());
		}

		// Token: 0x0601698A RID: 92554
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipClosedSurface_GetScalarModeMinValue_24(HandleRef pThis);

		/// <summary>
		/// Set whether to add cell scalars, so that new faces and outlines
		/// can be distinguished from original faces and lines.  The options
		/// are "None", "Colors", and "Labels".  For the "Labels" option,
		/// a scalar value of "0" indicates an original cell, "1" indicates
		/// a new cell on a cut face, and "2" indicates a new cell on the
		/// ActivePlane as set by the SetActivePlane() method.  The default
		/// scalar mode is "None".
		/// </summary>
		// Token: 0x0601698B RID: 92555 RVA: 0x001FCADC File Offset: 0x001FACDC
		public virtual int GetScalarModeMinValue()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetScalarModeMinValue_24(base.GetCppThis());
		}

		// Token: 0x0601698C RID: 92556
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkClipClosedSurface_GetTolerance_25(HandleRef pThis);

		/// <summary>
		/// Set the tolerance for creating new points while clipping.  If the
		/// tolerance is too small, then degenerate triangles might be produced.
		/// The default tolerance is 1e-6.
		/// </summary>
		// Token: 0x0601698D RID: 92557 RVA: 0x001FCAFC File Offset: 0x001FACFC
		public virtual double GetTolerance()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetTolerance_25(base.GetCppThis());
		}

		// Token: 0x0601698E RID: 92558
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipClosedSurface_GetTriangulationErrorDisplay_26(HandleRef pThis);

		/// <summary>
		/// Generate errors when the triangulation fails.  Usually the
		/// triangulation errors are too small to see, but they result in
		/// a surface that is not watertight.  This option has no impact
		/// on performance.
		/// </summary>
		// Token: 0x0601698F RID: 92559 RVA: 0x001FCB1C File Offset: 0x001FAD1C
		public virtual int GetTriangulationErrorDisplay()
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_GetTriangulationErrorDisplay_26(base.GetCppThis());
		}

		// Token: 0x06016990 RID: 92560
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipClosedSurface_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016991 RID: 92561 RVA: 0x001FCB3C File Offset: 0x001FAD3C
		public override int IsA(string type)
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x06016992 RID: 92562
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipClosedSurface_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016993 RID: 92563 RVA: 0x001FCB5C File Offset: 0x001FAD5C
		public new static int IsTypeOf(string type)
		{
			return vtkClipClosedSurface.vtkClipClosedSurface_IsTypeOf_28(type);
		}

		// Token: 0x06016994 RID: 92564
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipClosedSurface_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x06016995 RID: 92565 RVA: 0x001FCB78 File Offset: 0x001FAD78
		public new vtkClipClosedSurface NewInstance()
		{
			vtkClipClosedSurface result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipClosedSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016996 RID: 92566
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_PassPointDataOff_31(HandleRef pThis);

		/// <summary>
		/// Pass the point data to the output.  Point data will be interpolated
		/// when new points are generated.  This is off by default.
		/// </summary>
		// Token: 0x06016997 RID: 92567 RVA: 0x001FCBD2 File Offset: 0x001FADD2
		public virtual void PassPointDataOff()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_PassPointDataOff_31(base.GetCppThis());
		}

		// Token: 0x06016998 RID: 92568
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_PassPointDataOn_32(HandleRef pThis);

		/// <summary>
		/// Pass the point data to the output.  Point data will be interpolated
		/// when new points are generated.  This is off by default.
		/// </summary>
		// Token: 0x06016999 RID: 92569 RVA: 0x001FCBE1 File Offset: 0x001FADE1
		public virtual void PassPointDataOn()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_PassPointDataOn_32(base.GetCppThis());
		}

		// Token: 0x0601699A RID: 92570
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipClosedSurface_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0601699B RID: 92571 RVA: 0x001FCBF0 File Offset: 0x001FADF0
		public new static vtkClipClosedSurface SafeDownCast(vtkObjectBase o)
		{
			vtkClipClosedSurface vtkClipClosedSurface = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipClosedSurface.vtkClipClosedSurface_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipClosedSurface = (vtkClipClosedSurface)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipClosedSurface.Register(null);
				}
			}
			return vtkClipClosedSurface;
		}

		// Token: 0x0601699C RID: 92572
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetActivePlaneColor_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color for any new geometry produced by clipping with the
		/// ActivePlane, if ActivePlaneId is set.  Default is yellow.
		/// Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x0601699D RID: 92573 RVA: 0x001FCC6F File Offset: 0x001FAE6F
		public virtual void SetActivePlaneColor(double _arg1, double _arg2, double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetActivePlaneColor_34(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601699E RID: 92574
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetActivePlaneColor_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color for any new geometry produced by clipping with the
		/// ActivePlane, if ActivePlaneId is set.  Default is yellow.
		/// Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x0601699F RID: 92575 RVA: 0x001FCC81 File Offset: 0x001FAE81
		public virtual void SetActivePlaneColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetActivePlaneColor_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060169A0 RID: 92576
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetActivePlaneId_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the active plane, so that the clipping from that plane can be
		/// displayed in a different color.  Set this to -1 if there is no active
		/// plane.  The default value is -1.
		/// </summary>
		// Token: 0x060169A1 RID: 92577 RVA: 0x001FCC91 File Offset: 0x001FAE91
		public virtual void SetActivePlaneId(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetActivePlaneId_36(base.GetCppThis(), _arg);
		}

		// Token: 0x060169A2 RID: 92578
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetBaseColor_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color for all cells were part of the original geometry.
		/// If the input data already has color cell scalars, then those
		/// values will be used and parameter will be ignored.  The default color
		/// is red.  Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x060169A3 RID: 92579 RVA: 0x001FCCA1 File Offset: 0x001FAEA1
		public virtual void SetBaseColor(double _arg1, double _arg2, double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetBaseColor_37(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060169A4 RID: 92580
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetBaseColor_38(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color for all cells were part of the original geometry.
		/// If the input data already has color cell scalars, then those
		/// values will be used and parameter will be ignored.  The default color
		/// is red.  Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x060169A5 RID: 92581 RVA: 0x001FCCB3 File Offset: 0x001FAEB3
		public virtual void SetBaseColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetBaseColor_38(base.GetCppThis(), _arg);
		}

		// Token: 0x060169A6 RID: 92582
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetClipColor_39(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set the color for any new geometry, either faces or outlines, that are
		/// created as a result of the clipping. The default color is orange.
		/// Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x060169A7 RID: 92583 RVA: 0x001FCCC3 File Offset: 0x001FAEC3
		public virtual void SetClipColor(double _arg1, double _arg2, double _arg3)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetClipColor_39(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060169A8 RID: 92584
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetClipColor_40(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the color for any new geometry, either faces or outlines, that are
		/// created as a result of the clipping. The default color is orange.
		/// Requires SetScalarModeToColors.
		/// </summary>
		// Token: 0x060169A9 RID: 92585 RVA: 0x001FCCD5 File Offset: 0x001FAED5
		public virtual void SetClipColor(IntPtr _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetClipColor_40(base.GetCppThis(), _arg);
		}

		// Token: 0x060169AA RID: 92586
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetClippingPlanes_41(HandleRef pThis, HandleRef planes);

		/// <summary>
		/// Set the vtkPlaneCollection that holds the clipping planes.
		/// </summary>
		// Token: 0x060169AB RID: 92587 RVA: 0x001FCCE8 File Offset: 0x001FAEE8
		public virtual void SetClippingPlanes(vtkPlaneCollection planes)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetClippingPlanes_41(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		// Token: 0x060169AC RID: 92588
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetGenerateFaces_42(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to generate polygonal faces for the output.  This is
		/// on by default.  If it is off, then the output will have no polys.
		/// </summary>
		// Token: 0x060169AD RID: 92589 RVA: 0x001FCD17 File Offset: 0x001FAF17
		public virtual void SetGenerateFaces(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetGenerateFaces_42(base.GetCppThis(), _arg);
		}

		// Token: 0x060169AE RID: 92590
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetGenerateOutline_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to generate an outline wherever an input face was
		/// cut by a plane.  This is off by default.
		/// </summary>
		// Token: 0x060169AF RID: 92591 RVA: 0x001FCD27 File Offset: 0x001FAF27
		public virtual void SetGenerateOutline(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetGenerateOutline_43(base.GetCppThis(), _arg);
		}

		// Token: 0x060169B0 RID: 92592
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetPassPointData_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Pass the point data to the output.  Point data will be interpolated
		/// when new points are generated.  This is off by default.
		/// </summary>
		// Token: 0x060169B1 RID: 92593 RVA: 0x001FCD37 File Offset: 0x001FAF37
		public virtual void SetPassPointData(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetPassPointData_44(base.GetCppThis(), _arg);
		}

		// Token: 0x060169B2 RID: 92594
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetScalarMode_45(HandleRef pThis, int _arg);

		/// <summary>
		/// Set whether to add cell scalars, so that new faces and outlines
		/// can be distinguished from original faces and lines.  The options
		/// are "None", "Colors", and "Labels".  For the "Labels" option,
		/// a scalar value of "0" indicates an original cell, "1" indicates
		/// a new cell on a cut face, and "2" indicates a new cell on the
		/// ActivePlane as set by the SetActivePlane() method.  The default
		/// scalar mode is "None".
		/// </summary>
		// Token: 0x060169B3 RID: 92595 RVA: 0x001FCD47 File Offset: 0x001FAF47
		public virtual void SetScalarMode(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetScalarMode_45(base.GetCppThis(), _arg);
		}

		// Token: 0x060169B4 RID: 92596
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetScalarModeToColors_46(HandleRef pThis);

		/// <summary>
		/// Set whether to add cell scalars, so that new faces and outlines
		/// can be distinguished from original faces and lines.  The options
		/// are "None", "Colors", and "Labels".  For the "Labels" option,
		/// a scalar value of "0" indicates an original cell, "1" indicates
		/// a new cell on a cut face, and "2" indicates a new cell on the
		/// ActivePlane as set by the SetActivePlane() method.  The default
		/// scalar mode is "None".
		/// </summary>
		// Token: 0x060169B5 RID: 92597 RVA: 0x001FCD57 File Offset: 0x001FAF57
		public void SetScalarModeToColors()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetScalarModeToColors_46(base.GetCppThis());
		}

		// Token: 0x060169B6 RID: 92598
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetScalarModeToLabels_47(HandleRef pThis);

		/// <summary>
		/// Set whether to add cell scalars, so that new faces and outlines
		/// can be distinguished from original faces and lines.  The options
		/// are "None", "Colors", and "Labels".  For the "Labels" option,
		/// a scalar value of "0" indicates an original cell, "1" indicates
		/// a new cell on a cut face, and "2" indicates a new cell on the
		/// ActivePlane as set by the SetActivePlane() method.  The default
		/// scalar mode is "None".
		/// </summary>
		// Token: 0x060169B7 RID: 92599 RVA: 0x001FCD66 File Offset: 0x001FAF66
		public void SetScalarModeToLabels()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetScalarModeToLabels_47(base.GetCppThis());
		}

		// Token: 0x060169B8 RID: 92600
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetScalarModeToNone_48(HandleRef pThis);

		/// <summary>
		/// Set whether to add cell scalars, so that new faces and outlines
		/// can be distinguished from original faces and lines.  The options
		/// are "None", "Colors", and "Labels".  For the "Labels" option,
		/// a scalar value of "0" indicates an original cell, "1" indicates
		/// a new cell on a cut face, and "2" indicates a new cell on the
		/// ActivePlane as set by the SetActivePlane() method.  The default
		/// scalar mode is "None".
		/// </summary>
		// Token: 0x060169B9 RID: 92601 RVA: 0x001FCD75 File Offset: 0x001FAF75
		public void SetScalarModeToNone()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetScalarModeToNone_48(base.GetCppThis());
		}

		// Token: 0x060169BA RID: 92602
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetTolerance_49(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the tolerance for creating new points while clipping.  If the
		/// tolerance is too small, then degenerate triangles might be produced.
		/// The default tolerance is 1e-6.
		/// </summary>
		// Token: 0x060169BB RID: 92603 RVA: 0x001FCD84 File Offset: 0x001FAF84
		public virtual void SetTolerance(double _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetTolerance_49(base.GetCppThis(), _arg);
		}

		// Token: 0x060169BC RID: 92604
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_SetTriangulationErrorDisplay_50(HandleRef pThis, int _arg);

		/// <summary>
		/// Generate errors when the triangulation fails.  Usually the
		/// triangulation errors are too small to see, but they result in
		/// a surface that is not watertight.  This option has no impact
		/// on performance.
		/// </summary>
		// Token: 0x060169BD RID: 92605 RVA: 0x001FCD94 File Offset: 0x001FAF94
		public virtual void SetTriangulationErrorDisplay(int _arg)
		{
			vtkClipClosedSurface.vtkClipClosedSurface_SetTriangulationErrorDisplay_50(base.GetCppThis(), _arg);
		}

		// Token: 0x060169BE RID: 92606
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_TriangulationErrorDisplayOff_51(HandleRef pThis);

		/// <summary>
		/// Generate errors when the triangulation fails.  Usually the
		/// triangulation errors are too small to see, but they result in
		/// a surface that is not watertight.  This option has no impact
		/// on performance.
		/// </summary>
		// Token: 0x060169BF RID: 92607 RVA: 0x001FCDA4 File Offset: 0x001FAFA4
		public virtual void TriangulationErrorDisplayOff()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_TriangulationErrorDisplayOff_51(base.GetCppThis());
		}

		// Token: 0x060169C0 RID: 92608
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipClosedSurface_TriangulationErrorDisplayOn_52(HandleRef pThis);

		/// <summary>
		/// Generate errors when the triangulation fails.  Usually the
		/// triangulation errors are too small to see, but they result in
		/// a surface that is not watertight.  This option has no impact
		/// on performance.
		/// </summary>
		// Token: 0x060169C1 RID: 92609 RVA: 0x001FCDB3 File Offset: 0x001FAFB3
		public virtual void TriangulationErrorDisplayOn()
		{
			vtkClipClosedSurface.vtkClipClosedSurface_TriangulationErrorDisplayOn_52(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001963 RID: 6499
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipClosedSurface";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001964 RID: 6500
		public new static readonly string MRClassNameKey = "class vtkClipClosedSurface";
	}
}
