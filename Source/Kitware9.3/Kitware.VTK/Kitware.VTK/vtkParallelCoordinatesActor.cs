using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParallelCoordinatesActor
	/// </summary>
	/// <remarks>
	///    create parallel coordinate display from input field
	///
	/// vtkParallelCoordinatesActor generates a parallel coordinates plot from an
	/// input field (i.e., vtkDataObject). Parallel coordinates represent
	/// N-dimensional data by using a set of N parallel axes (not orthogonal like
	/// the usual x-y-z Cartesian axes). Each N-dimensional point is plotted as a
	/// polyline, were each of the N components of the point lie on one of the
	/// N axes, and the components are connected by straight lines.
	///
	/// To use this class, you must specify an input data object. You'll probably
	/// also want to specify the position of the plot be setting the Position and
	/// Position2 instance variables, which define a rectangle in which the plot
	/// lies. Another important parameter is the IndependentVariables ivar, which
	/// tells the instance how to interpret the field data (independent variables
	/// as the rows or columns of the field). There are also many other instance
	/// variables that control the look of the plot includes its title,
	/// attributes, number of ticks on the axes, etc.
	///
	/// Set the text property/attributes of the title and the labels through the
	/// vtkTextProperty objects associated to this actor.
	///
	/// @warning
	/// Field data is not necessarily "rectangular" in shape. In these cases, some
	/// of the data may not be plotted.
	///
	/// @warning
	/// Field data can contain non-numeric arrays (i.e. arrays not subclasses of
	/// vtkDataArray). Such arrays are skipped.
	///
	/// @warning
	/// The early implementation lacks many features that could be added in the
	/// future. This includes the ability to "brush" data (choose regions along an
	/// axis and highlight any points/lines passing through the region);
	/// efficiency is really bad; more control over the properties of the plot
	/// (separate properties for each axes,title,etc.; and using the labels found
	/// in the field to label each of the axes.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAxisActor3D can be used to create axes in world coordinate space.
	/// vtkActor2D vtkTextMapper vtkPolyDataMapper2D vtkScalarBarActor
	/// vtkCoordinate vtkTextProperty
	/// </seealso>
	// Token: 0x020003D1 RID: 977
	public class vtkParallelCoordinatesActor : vtkActor2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600B68A RID: 46730 RVA: 0x00100D2B File Offset: 0x000FEF2B
		static vtkParallelCoordinatesActor()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelCoordinatesActor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelCoordinatesActor"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600B68B RID: 46731 RVA: 0x00100D53 File Offset: 0x000FEF53
		public vtkParallelCoordinatesActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600B68C RID: 46732
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate object with autorange computation;
		/// the number of labels set to 5 for the x and y axes;
		/// a label format of "%-#6.3g"; and x coordinates computed from point
		/// ids.
		/// </summary>
		// Token: 0x0600B68D RID: 46733 RVA: 0x00100D64 File Offset: 0x000FEF64
		public new static vtkParallelCoordinatesActor New()
		{
			vtkParallelCoordinatesActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate object with autorange computation;
		/// the number of labels set to 5 for the x and y axes;
		/// a label format of "%-#6.3g"; and x coordinates computed from point
		/// ids.
		/// </summary>
		// Token: 0x0600B68E RID: 46734 RVA: 0x00100DB8 File Offset: 0x000FEFB8
		public vtkParallelCoordinatesActor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600B68F RID: 46735 RVA: 0x00100DFC File Offset: 0x000FEFFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600B690 RID: 46736
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_GetIndependentVariables_01(HandleRef pThis);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600B691 RID: 46737 RVA: 0x00100E08 File Offset: 0x000FF008
		public virtual int GetIndependentVariables()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetIndependentVariables_01(base.GetCppThis());
		}

		// Token: 0x0600B692 RID: 46738
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_GetIndependentVariablesMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600B693 RID: 46739 RVA: 0x00100E28 File Offset: 0x000FF028
		public virtual int GetIndependentVariablesMaxValue()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetIndependentVariablesMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600B694 RID: 46740
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_GetIndependentVariablesMinValue_03(HandleRef pThis);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600B695 RID: 46741 RVA: 0x00100E48 File Offset: 0x000FF048
		public virtual int GetIndependentVariablesMinValue()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetIndependentVariablesMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600B696 RID: 46742
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesActor_GetInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Remove a dataset from the list of data to append.
		/// </summary>
		// Token: 0x0600B697 RID: 46743 RVA: 0x00100E68 File Offset: 0x000FF068
		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetInput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0600B698 RID: 46744
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesActor_GetLabelFormat_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the format with which to print the labels on the axes.
		/// </summary>
		// Token: 0x0600B699 RID: 46745 RVA: 0x00100ED8 File Offset: 0x000FF0D8
		public virtual string GetLabelFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetLabelFormat_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B69A RID: 46746
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesActor_GetLabelTextProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the labels text property.
		/// </summary>
		// Token: 0x0600B69B RID: 46747 RVA: 0x00100F14 File Offset: 0x000FF114
		public virtual vtkTextProperty GetLabelTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetLabelTextProperty_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B69C RID: 46748
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelCoordinatesActor_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B69D RID: 46749 RVA: 0x00100F84 File Offset: 0x000FF184
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600B69E RID: 46750
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParallelCoordinatesActor_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B69F RID: 46751 RVA: 0x00100FA4 File Offset: 0x000FF1A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600B6A0 RID: 46752
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_GetNumberOfLabels_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of annotation labels to show along each axis.
		/// This values is a suggestion: the number of labels may vary depending
		/// on the particulars of the data.
		/// </summary>
		// Token: 0x0600B6A1 RID: 46753 RVA: 0x00100FC0 File Offset: 0x000FF1C0
		public virtual int GetNumberOfLabels()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetNumberOfLabels_09(base.GetCppThis());
		}

		// Token: 0x0600B6A2 RID: 46754
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_GetNumberOfLabelsMaxValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of annotation labels to show along each axis.
		/// This values is a suggestion: the number of labels may vary depending
		/// on the particulars of the data.
		/// </summary>
		// Token: 0x0600B6A3 RID: 46755 RVA: 0x00100FE0 File Offset: 0x000FF1E0
		public virtual int GetNumberOfLabelsMaxValue()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetNumberOfLabelsMaxValue_10(base.GetCppThis());
		}

		// Token: 0x0600B6A4 RID: 46756
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_GetNumberOfLabelsMinValue_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of annotation labels to show along each axis.
		/// This values is a suggestion: the number of labels may vary depending
		/// on the particulars of the data.
		/// </summary>
		// Token: 0x0600B6A5 RID: 46757 RVA: 0x00101000 File Offset: 0x000FF200
		public virtual int GetNumberOfLabelsMinValue()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetNumberOfLabelsMinValue_11(base.GetCppThis());
		}

		// Token: 0x0600B6A6 RID: 46758
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesActor_GetTitle_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the title of the parallel coordinates plot.
		/// </summary>
		// Token: 0x0600B6A7 RID: 46759 RVA: 0x00101020 File Offset: 0x000FF220
		public virtual string GetTitle()
		{
			string s = Marshal.PtrToStringAnsi(vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetTitle_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600B6A8 RID: 46760
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesActor_GetTitleTextProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600B6A9 RID: 46761 RVA: 0x0010105C File Offset: 0x000FF25C
		public virtual vtkTextProperty GetTitleTextProperty()
		{
			vtkTextProperty vtkTextProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_GetTitleTextProperty_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextProperty = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextProperty.Register(null);
				}
			}
			return vtkTextProperty;
		}

		// Token: 0x0600B6AA RID: 46762
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_HasTranslucentPolygonalGeometry_14(HandleRef pThis);

		/// <summary>
		/// Does this prop have some translucent polygonal geometry?
		/// </summary>
		// Token: 0x0600B6AB RID: 46763 RVA: 0x001010CC File Offset: 0x000FF2CC
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_HasTranslucentPolygonalGeometry_14(base.GetCppThis());
		}

		// Token: 0x0600B6AC RID: 46764
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B6AD RID: 46765 RVA: 0x001010EC File Offset: 0x000FF2EC
		public override int IsA(string type)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x0600B6AE RID: 46766
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B6AF RID: 46767 RVA: 0x0010110C File Offset: 0x000FF30C
		public new static int IsTypeOf(string type)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_IsTypeOf_16(type);
		}

		// Token: 0x0600B6B0 RID: 46768
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesActor_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B6B1 RID: 46769 RVA: 0x00101128 File Offset: 0x000FF328
		public new vtkParallelCoordinatesActor NewInstance()
		{
			vtkParallelCoordinatesActor result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelCoordinatesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600B6B2 RID: 46770
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Release any graphics resources that are being consumed by this actor.
		/// The parameter window could be used to determine which graphic
		/// resources to release.
		/// </summary>
		// Token: 0x0600B6B3 RID: 46771 RVA: 0x00101184 File Offset: 0x000FF384
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_ReleaseGraphicsResources_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B6B4 RID: 46772
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_RenderOpaqueGeometry_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the parallel coordinates plot.
		/// </summary>
		// Token: 0x0600B6B5 RID: 46773 RVA: 0x001011B4 File Offset: 0x000FF3B4
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_RenderOpaqueGeometry_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B6B6 RID: 46774
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_RenderOverlay_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the parallel coordinates plot.
		/// </summary>
		// Token: 0x0600B6B7 RID: 46775 RVA: 0x001011E8 File Offset: 0x000FF3E8
		public override int RenderOverlay(vtkViewport arg0)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_RenderOverlay_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B6B8 RID: 46776
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParallelCoordinatesActor_RenderTranslucentPolygonalGeometry_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Draw the parallel coordinates plot.
		/// </summary>
		// Token: 0x0600B6B9 RID: 46777 RVA: 0x0010121C File Offset: 0x000FF41C
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_RenderTranslucentPolygonalGeometry_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B6BA RID: 46778
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParallelCoordinatesActor_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600B6BB RID: 46779 RVA: 0x00101250 File Offset: 0x000FF450
		public new static vtkParallelCoordinatesActor SafeDownCast(vtkObjectBase o)
		{
			vtkParallelCoordinatesActor vtkParallelCoordinatesActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelCoordinatesActor = (vtkParallelCoordinatesActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelCoordinatesActor.Register(null);
				}
			}
			return vtkParallelCoordinatesActor;
		}

		// Token: 0x0600B6BC RID: 46780
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_SetIndependentVariables_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600B6BD RID: 46781 RVA: 0x001012CF File Offset: 0x000FF4CF
		public virtual void SetIndependentVariables(int _arg)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetIndependentVariables_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B6BE RID: 46782
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_SetIndependentVariablesToColumns_25(HandleRef pThis);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600B6BF RID: 46783 RVA: 0x001012DF File Offset: 0x000FF4DF
		public void SetIndependentVariablesToColumns()
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetIndependentVariablesToColumns_25(base.GetCppThis());
		}

		// Token: 0x0600B6C0 RID: 46784
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_SetIndependentVariablesToRows_26(HandleRef pThis);

		/// <summary>
		/// Specify whether to use the rows or columns as independent variables.
		/// If columns, then each row represents a separate point. If rows, then
		/// each column represents a separate point.
		/// </summary>
		// Token: 0x0600B6C1 RID: 46785 RVA: 0x001012EE File Offset: 0x000FF4EE
		public void SetIndependentVariablesToRows()
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetIndependentVariablesToRows_26(base.GetCppThis());
		}

		// Token: 0x0600B6C2 RID: 46786
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_SetInputConnection_27(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input to the parallel coordinates actor. Creates
		/// a pipeline connection.
		/// </summary>
		// Token: 0x0600B6C3 RID: 46787 RVA: 0x00101300 File Offset: 0x000FF500
		public virtual void SetInputConnection(vtkAlgorithmOutput arg0)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetInputConnection_27(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B6C4 RID: 46788
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_SetInputData_28(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the input to the parallel coordinates actor. Does not
		/// create a pipeline connection.
		/// </summary>
		// Token: 0x0600B6C5 RID: 46789 RVA: 0x00101330 File Offset: 0x000FF530
		public virtual void SetInputData(vtkDataObject arg0)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetInputData_28(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600B6C6 RID: 46790
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_SetLabelFormat_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the format with which to print the labels on the axes.
		/// </summary>
		// Token: 0x0600B6C7 RID: 46791 RVA: 0x0010135F File Offset: 0x000FF55F
		public virtual void SetLabelFormat(string _arg)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetLabelFormat_29(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B6C8 RID: 46792
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_SetLabelTextProperty_30(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the labels text property.
		/// </summary>
		// Token: 0x0600B6C9 RID: 46793 RVA: 0x00101370 File Offset: 0x000FF570
		public virtual void SetLabelTextProperty(vtkTextProperty p)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetLabelTextProperty_30(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		// Token: 0x0600B6CA RID: 46794
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_SetNumberOfLabels_31(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of annotation labels to show along each axis.
		/// This values is a suggestion: the number of labels may vary depending
		/// on the particulars of the data.
		/// </summary>
		// Token: 0x0600B6CB RID: 46795 RVA: 0x0010139F File Offset: 0x000FF59F
		public virtual void SetNumberOfLabels(int _arg)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetNumberOfLabels_31(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B6CC RID: 46796
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_SetTitle_32(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the title of the parallel coordinates plot.
		/// </summary>
		// Token: 0x0600B6CD RID: 46797 RVA: 0x001013AF File Offset: 0x000FF5AF
		public virtual void SetTitle(string _arg)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetTitle_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600B6CE RID: 46798
		[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParallelCoordinatesActor_SetTitleTextProperty_33(HandleRef pThis, HandleRef p);

		/// <summary>
		/// Set/Get the title text property.
		/// </summary>
		// Token: 0x0600B6CF RID: 46799 RVA: 0x001013C0 File Offset: 0x000FF5C0
		public virtual void SetTitleTextProperty(vtkTextProperty p)
		{
			vtkParallelCoordinatesActor.vtkParallelCoordinatesActor_SetTitleTextProperty_33(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DFD RID: 3581
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelCoordinatesActor";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000DFE RID: 3582
		public new static readonly string MRClassNameKey = "class vtkParallelCoordinatesActor";
	}
}
