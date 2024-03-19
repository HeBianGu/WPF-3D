using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageConnectivityFilter
	/// </summary>
	/// <remarks>
	///    Label an image by connectivity
	///
	/// vtkImageConnectivityFilter will identify connected regions within an
	/// image and label them.  Only points with scalar values within a
	/// prescribed range are considered for inclusion, by default this range
	/// includes all scalar values with a value greater than zero.  Points
	/// within the prescribed scalar range are considered to be connected
	/// if a path exists between the points that does not traverse any
	/// points that are not within the prescribed scalar range.
	/// Adjacency of points is governed by 4-connectivity for 2D images, and
	/// 6-connectivity for 3D images.
	///
	/// The output of this filter is a label image.  By default, each region
	/// is assigned a different label, where the labels are integer values
	/// starting at a value of 1.  The SetLabelMode() method can be used to
	/// change the way that labels are assigned.  Labels can be assigned
	/// by providing input seed points for each region to be labelled, or
	/// they can be assigned by ranking the regions by size.
	///
	/// If a set of seeds is provided with the SetSeedData() method,
	/// then the default behavior is to only output the regions that are
	/// connected to the seeds, and if the seeds have scalars, then these
	/// scalars will be used to label the regions.  Seeds with a scalar
	/// value equal to zero are ignored.  See the documentation for the
	/// SetExtractionMode() method for details on how to control which
	/// regions will labeled.
	///
	/// Regions can be selected by size with the SetSizeRange() method,
	/// which can be useful for identifying objects of a certain size,
	/// e.g. for rejecting small regions that are likely to be noise.
	/// It is also possible to label only the largest region and ignore
	/// all others, with SetExtractionModeToLargestRegion().
	///
	/// In addition to the labels, the following additional information
	/// is provided: the number of regions identified, the size of each
	/// region, a list of all label values used, and the seed for each
	/// region (if seeds were used).  Optionally, this filter can also
	/// compute the extent of each region if GenerateRegionExtentsOn()
	/// is called.  These extents can be useful for cropping the output
	/// of the filter.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkConnectivityFilter, vtkPolyDataConnectivityFilter, vtkmImageConnectivity
	/// </seealso>
	// Token: 0x02000243 RID: 579
	public class vtkImageConnectivityFilter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006BD9 RID: 27609 RVA: 0x0009BA29 File Offset: 0x00099C29
		static vtkImageConnectivityFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageConnectivityFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageConnectivityFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006BDA RID: 27610 RVA: 0x0009BA51 File Offset: 0x00099C51
		public vtkImageConnectivityFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006BDB RID: 27611
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006BDC RID: 27612 RVA: 0x0009BA60 File Offset: 0x00099C60
		public new static vtkImageConnectivityFilter New()
		{
			vtkImageConnectivityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006BDD RID: 27613 RVA: 0x0009BAB4 File Offset: 0x00099CB4
		public vtkImageConnectivityFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageConnectivityFilter.vtkImageConnectivityFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006BDE RID: 27614 RVA: 0x0009BAF8 File Offset: 0x00099CF8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006BDF RID: 27615
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_GenerateRegionExtentsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn this on to request creation of the ExtractedRegionExtents array.
		/// </summary>
		// Token: 0x06006BE0 RID: 27616 RVA: 0x0009BB03 File Offset: 0x00099D03
		public virtual void GenerateRegionExtentsOff()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_GenerateRegionExtentsOff_01(base.GetCppThis());
		}

		// Token: 0x06006BE1 RID: 27617
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_GenerateRegionExtentsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn this on to request creation of the ExtractedRegionExtents array.
		/// </summary>
		// Token: 0x06006BE2 RID: 27618 RVA: 0x0009BB12 File Offset: 0x00099D12
		public virtual void GenerateRegionExtentsOn()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_GenerateRegionExtentsOn_02(base.GetCppThis());
		}

		// Token: 0x06006BE3 RID: 27619
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConnectivityFilter_GetActiveComponent_03(HandleRef pThis);

		/// <summary>
		/// For multi-component input images, select which component to use.
		/// </summary>
		// Token: 0x06006BE4 RID: 27620 RVA: 0x0009BB24 File Offset: 0x00099D24
		public virtual int GetActiveComponent()
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetActiveComponent_03(base.GetCppThis());
		}

		// Token: 0x06006BE5 RID: 27621
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetExtractedRegionExtents_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the extent (a 6-tuples) for each output region.
		/// This is only valid if GenerateRegionExtentsOn() was called before
		/// the filter was executed.
		/// </summary>
		// Token: 0x06006BE6 RID: 27622 RVA: 0x0009BB44 File Offset: 0x00099D44
		public vtkIntArray GetExtractedRegionExtents()
		{
			vtkIntArray vtkIntArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetExtractedRegionExtents_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIntArray = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIntArray.Register(null);
				}
			}
			return vtkIntArray;
		}

		// Token: 0x06006BE7 RID: 27623
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetExtractedRegionLabels_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the label used for each extracted region.
		/// </summary>
		// Token: 0x06006BE8 RID: 27624 RVA: 0x0009BBB4 File Offset: 0x00099DB4
		public vtkIdTypeArray GetExtractedRegionLabels()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetExtractedRegionLabels_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x06006BE9 RID: 27625
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetExtractedRegionSeedIds_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the PointId of the seed for each region.
		/// If no seed was used, the PointId will be -1.
		/// </summary>
		// Token: 0x06006BEA RID: 27626 RVA: 0x0009BC24 File Offset: 0x00099E24
		public vtkIdTypeArray GetExtractedRegionSeedIds()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetExtractedRegionSeedIds_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x06006BEB RID: 27627
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetExtractedRegionSizes_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the label used for each extracted region.
		/// </summary>
		// Token: 0x06006BEC RID: 27628 RVA: 0x0009BC94 File Offset: 0x00099E94
		public vtkIdTypeArray GetExtractedRegionSizes()
		{
			vtkIdTypeArray vtkIdTypeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetExtractedRegionSizes_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdTypeArray = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdTypeArray.Register(null);
				}
			}
			return vtkIdTypeArray;
		}

		// Token: 0x06006BED RID: 27629
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConnectivityFilter_GetExtractionMode_08(HandleRef pThis);

		/// <summary>
		/// Set which regions to output from this filter.
		/// This can be all the regions, just the seeded regions, or the largest
		/// region (which will be the largest seeded region, if there are seeds).
		/// The default is to output all the seeded regions, if there are seeds,
		/// or to output all the regions, if there are no seeds.
		/// </summary>
		// Token: 0x06006BEE RID: 27630 RVA: 0x0009BD04 File Offset: 0x00099F04
		public virtual int GetExtractionMode()
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetExtractionMode_08(base.GetCppThis());
		}

		// Token: 0x06006BEF RID: 27631
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetExtractionModeAsString_09(HandleRef pThis);

		/// <summary>
		/// Set which regions to output from this filter.
		/// This can be all the regions, just the seeded regions, or the largest
		/// region (which will be the largest seeded region, if there are seeds).
		/// The default is to output all the seeded regions, if there are seeds,
		/// or to output all the regions, if there are no seeds.
		/// </summary>
		// Token: 0x06006BF0 RID: 27632 RVA: 0x0009BD24 File Offset: 0x00099F24
		public string GetExtractionModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetExtractionModeAsString_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006BF1 RID: 27633
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConnectivityFilter_GetGenerateRegionExtents_10(HandleRef pThis);

		/// <summary>
		/// Turn this on to request creation of the ExtractedRegionExtents array.
		/// </summary>
		// Token: 0x06006BF2 RID: 27634 RVA: 0x0009BD60 File Offset: 0x00099F60
		public virtual int GetGenerateRegionExtents()
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetGenerateRegionExtents_10(base.GetCppThis());
		}

		// Token: 0x06006BF3 RID: 27635
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConnectivityFilter_GetLabelConstantValue_11(HandleRef pThis);

		/// <summary>
		/// The label used when LabelMode is ConstantValue.
		/// The default value is 255.
		/// </summary>
		// Token: 0x06006BF4 RID: 27636 RVA: 0x0009BD80 File Offset: 0x00099F80
		public virtual int GetLabelConstantValue()
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetLabelConstantValue_11(base.GetCppThis());
		}

		// Token: 0x06006BF5 RID: 27637
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConnectivityFilter_GetLabelMode_12(HandleRef pThis);

		/// <summary>
		/// Set the mode for applying labels to the output.
		/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
		/// present, or the regions will be labeled consecutively starting at 1,
		/// if the seeds have no scalars. Labeling by SizeRank means that the
		/// largest region is labeled 1 and other regions are labeled consecutively
		/// in order of decreasing size (if there is a tie, then the seed point ID
		/// is used as a tiebreaker).  Finally, Constant means that all regions
		/// will have the value of SetLabelConstantValue().  The default is to
		/// label using the seed scalars, if present, or to label consecutively,
		/// if no seed scalars are present.
		/// </summary>
		// Token: 0x06006BF6 RID: 27638 RVA: 0x0009BDA0 File Offset: 0x00099FA0
		public virtual int GetLabelMode()
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetLabelMode_12(base.GetCppThis());
		}

		// Token: 0x06006BF7 RID: 27639
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetLabelModeAsString_13(HandleRef pThis);

		/// <summary>
		/// Set the mode for applying labels to the output.
		/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
		/// present, or the regions will be labeled consecutively starting at 1,
		/// if the seeds have no scalars. Labeling by SizeRank means that the
		/// largest region is labeled 1 and other regions are labeled consecutively
		/// in order of decreasing size (if there is a tie, then the seed point ID
		/// is used as a tiebreaker).  Finally, Constant means that all regions
		/// will have the value of SetLabelConstantValue().  The default is to
		/// label using the seed scalars, if present, or to label consecutively,
		/// if no seed scalars are present.
		/// </summary>
		// Token: 0x06006BF8 RID: 27640 RVA: 0x0009BDC0 File Offset: 0x00099FC0
		public string GetLabelModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetLabelModeAsString_13(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006BF9 RID: 27641
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConnectivityFilter_GetLabelScalarType_14(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for the output label image.
		/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
		/// depending on how many labels are expected.  The default is UnsignedChar,
		/// which allows for 255 label values.  If the total number of regions is
		/// greater than the maximum label value N, then only the largest N regions
		/// will be kept and the rest will be discarded.
		/// </summary>
		// Token: 0x06006BFA RID: 27642 RVA: 0x0009BDFC File Offset: 0x00099FFC
		public virtual int GetLabelScalarType()
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetLabelScalarType_14(base.GetCppThis());
		}

		// Token: 0x06006BFB RID: 27643
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetLabelScalarTypeAsString_15(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for the output label image.
		/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
		/// depending on how many labels are expected.  The default is UnsignedChar,
		/// which allows for 255 label values.  If the total number of regions is
		/// greater than the maximum label value N, then only the largest N regions
		/// will be kept and the rest will be discarded.
		/// </summary>
		// Token: 0x06006BFC RID: 27644 RVA: 0x0009BE1C File Offset: 0x0009A01C
		public string GetLabelScalarTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetLabelScalarTypeAsString_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006BFD RID: 27645
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageConnectivityFilter_GetNumberOfExtractedRegions_16(HandleRef pThis);

		/// <summary>
		/// Get the number of extracted regions.
		/// </summary>
		// Token: 0x06006BFE RID: 27646 RVA: 0x0009BE58 File Offset: 0x0009A058
		public long GetNumberOfExtractedRegions()
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetNumberOfExtractedRegions_16(base.GetCppThis());
		}

		// Token: 0x06006BFF RID: 27647
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageConnectivityFilter_GetNumberOfGenerationsFromBase_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C00 RID: 27648 RVA: 0x0009BE78 File Offset: 0x0009A078
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetNumberOfGenerationsFromBase_17(base.GetCppThis(), type);
		}

		// Token: 0x06006C01 RID: 27649
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageConnectivityFilter_GetNumberOfGenerationsFromBaseType_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C02 RID: 27650 RVA: 0x0009BE98 File Offset: 0x0009A098
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetNumberOfGenerationsFromBaseType_18(type);
		}

		// Token: 0x06006C03 RID: 27651
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetScalarRange_19(HandleRef pThis);

		/// <summary>
		/// Set the scalar range used to define potential regions.
		/// Only voxels with values that are within this range will be considered
		/// for region membership.  This is an inclusive range, meaning that the
		/// upper and lower limits are considered to be within the range.  The
		/// default range goes from 0.5 to VTK_DOUBLE_MAX.
		/// </summary>
		// Token: 0x06006C04 RID: 27652 RVA: 0x0009BEB4 File Offset: 0x0009A0B4
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetScalarRange_19(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006C05 RID: 27653
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_GetScalarRange_20(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set the scalar range used to define potential regions.
		/// Only voxels with values that are within this range will be considered
		/// for region membership.  This is an inclusive range, meaning that the
		/// upper and lower limits are considered to be within the range.  The
		/// default range goes from 0.5 to VTK_DOUBLE_MAX.
		/// </summary>
		// Token: 0x06006C06 RID: 27654 RVA: 0x0009BEFC File Offset: 0x0009A0FC
		public virtual void GetScalarRange(ref double _arg1, ref double _arg2)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetScalarRange_20(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06006C07 RID: 27655
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_GetScalarRange_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range used to define potential regions.
		/// Only voxels with values that are within this range will be considered
		/// for region membership.  This is an inclusive range, meaning that the
		/// upper and lower limits are considered to be within the range.  The
		/// default range goes from 0.5 to VTK_DOUBLE_MAX.
		/// </summary>
		// Token: 0x06006C08 RID: 27656 RVA: 0x0009BF0D File Offset: 0x0009A10D
		public virtual void GetScalarRange(IntPtr _arg)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetScalarRange_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C09 RID: 27657
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetSeedConnection_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The input for seed locations (input port 1).
		/// Each point in the supplied data set will be used as a seed, unless
		/// the data set has scalars, in which case only the points with scalar
		/// values that are not equal to zero will be used as seeds.
		/// </summary>
		// Token: 0x06006C0A RID: 27658 RVA: 0x0009BF20 File Offset: 0x0009A120
		public vtkAlgorithmOutput GetSeedConnection()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetSeedConnection_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06006C0B RID: 27659
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetSizeRange_23(HandleRef pThis);

		/// <summary>
		/// Set the size range for the extracted regions.
		/// Only regions that have sizes within the specified range will be present
		/// in the output.  The default range is (1, VTK_ID_MAX).
		/// </summary>
		// Token: 0x06006C0C RID: 27660 RVA: 0x0009BF90 File Offset: 0x0009A190
		public virtual long[] GetSizeRange()
		{
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetSizeRange_23(base.GetCppThis());
			long[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new long[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006C0D RID: 27661
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_GetSizeRange_24(HandleRef pThis, ref long _arg1, ref long _arg2);

		/// <summary>
		/// Set the size range for the extracted regions.
		/// Only regions that have sizes within the specified range will be present
		/// in the output.  The default range is (1, VTK_ID_MAX).
		/// </summary>
		// Token: 0x06006C0E RID: 27662 RVA: 0x0009BFD8 File Offset: 0x0009A1D8
		public virtual void GetSizeRange(ref long _arg1, ref long _arg2)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetSizeRange_24(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06006C0F RID: 27663
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_GetSizeRange_25(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the size range for the extracted regions.
		/// Only regions that have sizes within the specified range will be present
		/// in the output.  The default range is (1, VTK_ID_MAX).
		/// </summary>
		// Token: 0x06006C10 RID: 27664 RVA: 0x0009BFE9 File Offset: 0x0009A1E9
		public virtual void GetSizeRange(IntPtr _arg)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetSizeRange_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C11 RID: 27665
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_GetStencilConnection_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The input for a stencil (input port 2).
		/// The output labels will be restricted to the region inside the stencil,
		/// as if no input voxels existed outside the stencil.  This allows you to
		/// apply this filter within an arbitrary region of interest.
		/// </summary>
		// Token: 0x06006C12 RID: 27666 RVA: 0x0009BFFC File Offset: 0x0009A1FC
		public vtkAlgorithmOutput GetStencilConnection()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_GetStencilConnection_26(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x06006C13 RID: 27667
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConnectivityFilter_IsA_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C14 RID: 27668 RVA: 0x0009C06C File Offset: 0x0009A26C
		public override int IsA(string type)
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_IsA_27(base.GetCppThis(), type);
		}

		// Token: 0x06006C15 RID: 27669
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConnectivityFilter_IsTypeOf_28([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C16 RID: 27670 RVA: 0x0009C08C File Offset: 0x0009A28C
		public new static int IsTypeOf(string type)
		{
			return vtkImageConnectivityFilter.vtkImageConnectivityFilter_IsTypeOf_28(type);
		}

		// Token: 0x06006C17 RID: 27671
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C18 RID: 27672 RVA: 0x0009C0A8 File Offset: 0x0009A2A8
		public new vtkImageConnectivityFilter NewInstance()
		{
			vtkImageConnectivityFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_NewInstance_30(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006C19 RID: 27673
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConnectivityFilter_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006C1A RID: 27674 RVA: 0x0009C104 File Offset: 0x0009A304
		public new static vtkImageConnectivityFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImageConnectivityFilter vtkImageConnectivityFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConnectivityFilter.vtkImageConnectivityFilter_SafeDownCast_31((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageConnectivityFilter = (vtkImageConnectivityFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageConnectivityFilter.Register(null);
				}
			}
			return vtkImageConnectivityFilter;
		}

		// Token: 0x06006C1B RID: 27675
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetActiveComponent_32(HandleRef pThis, int _arg);

		/// <summary>
		/// For multi-component input images, select which component to use.
		/// </summary>
		// Token: 0x06006C1C RID: 27676 RVA: 0x0009C183 File Offset: 0x0009A383
		public virtual void SetActiveComponent(int _arg)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetActiveComponent_32(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C1D RID: 27677
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetExtractionMode_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set which regions to output from this filter.
		/// This can be all the regions, just the seeded regions, or the largest
		/// region (which will be the largest seeded region, if there are seeds).
		/// The default is to output all the seeded regions, if there are seeds,
		/// or to output all the regions, if there are no seeds.
		/// </summary>
		// Token: 0x06006C1E RID: 27678 RVA: 0x0009C193 File Offset: 0x0009A393
		public virtual void SetExtractionMode(int _arg)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetExtractionMode_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C1F RID: 27679
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetExtractionModeToAllRegions_34(HandleRef pThis);

		/// <summary>
		/// Set which regions to output from this filter.
		/// This can be all the regions, just the seeded regions, or the largest
		/// region (which will be the largest seeded region, if there are seeds).
		/// The default is to output all the seeded regions, if there are seeds,
		/// or to output all the regions, if there are no seeds.
		/// </summary>
		// Token: 0x06006C20 RID: 27680 RVA: 0x0009C1A3 File Offset: 0x0009A3A3
		public void SetExtractionModeToAllRegions()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetExtractionModeToAllRegions_34(base.GetCppThis());
		}

		// Token: 0x06006C21 RID: 27681
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetExtractionModeToLargestRegion_35(HandleRef pThis);

		/// <summary>
		/// Set which regions to output from this filter.
		/// This can be all the regions, just the seeded regions, or the largest
		/// region (which will be the largest seeded region, if there are seeds).
		/// The default is to output all the seeded regions, if there are seeds,
		/// or to output all the regions, if there are no seeds.
		/// </summary>
		// Token: 0x06006C22 RID: 27682 RVA: 0x0009C1B2 File Offset: 0x0009A3B2
		public void SetExtractionModeToLargestRegion()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetExtractionModeToLargestRegion_35(base.GetCppThis());
		}

		// Token: 0x06006C23 RID: 27683
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetExtractionModeToSeededRegions_36(HandleRef pThis);

		/// <summary>
		/// Set which regions to output from this filter.
		/// This can be all the regions, just the seeded regions, or the largest
		/// region (which will be the largest seeded region, if there are seeds).
		/// The default is to output all the seeded regions, if there are seeds,
		/// or to output all the regions, if there are no seeds.
		/// </summary>
		// Token: 0x06006C24 RID: 27684 RVA: 0x0009C1C1 File Offset: 0x0009A3C1
		public void SetExtractionModeToSeededRegions()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetExtractionModeToSeededRegions_36(base.GetCppThis());
		}

		// Token: 0x06006C25 RID: 27685
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetGenerateRegionExtents_37(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn this on to request creation of the ExtractedRegionExtents array.
		/// </summary>
		// Token: 0x06006C26 RID: 27686 RVA: 0x0009C1D0 File Offset: 0x0009A3D0
		public virtual void SetGenerateRegionExtents(int _arg)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetGenerateRegionExtents_37(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C27 RID: 27687
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetLabelConstantValue_38(HandleRef pThis, int _arg);

		/// <summary>
		/// The label used when LabelMode is ConstantValue.
		/// The default value is 255.
		/// </summary>
		// Token: 0x06006C28 RID: 27688 RVA: 0x0009C1E0 File Offset: 0x0009A3E0
		public virtual void SetLabelConstantValue(int _arg)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetLabelConstantValue_38(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C29 RID: 27689
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetLabelMode_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the mode for applying labels to the output.
		/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
		/// present, or the regions will be labeled consecutively starting at 1,
		/// if the seeds have no scalars. Labeling by SizeRank means that the
		/// largest region is labeled 1 and other regions are labeled consecutively
		/// in order of decreasing size (if there is a tie, then the seed point ID
		/// is used as a tiebreaker).  Finally, Constant means that all regions
		/// will have the value of SetLabelConstantValue().  The default is to
		/// label using the seed scalars, if present, or to label consecutively,
		/// if no seed scalars are present.
		/// </summary>
		// Token: 0x06006C2A RID: 27690 RVA: 0x0009C1F0 File Offset: 0x0009A3F0
		public virtual void SetLabelMode(int _arg)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetLabelMode_39(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C2B RID: 27691
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetLabelModeToConstantValue_40(HandleRef pThis);

		/// <summary>
		/// Set the mode for applying labels to the output.
		/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
		/// present, or the regions will be labeled consecutively starting at 1,
		/// if the seeds have no scalars. Labeling by SizeRank means that the
		/// largest region is labeled 1 and other regions are labeled consecutively
		/// in order of decreasing size (if there is a tie, then the seed point ID
		/// is used as a tiebreaker).  Finally, Constant means that all regions
		/// will have the value of SetLabelConstantValue().  The default is to
		/// label using the seed scalars, if present, or to label consecutively,
		/// if no seed scalars are present.
		/// </summary>
		// Token: 0x06006C2C RID: 27692 RVA: 0x0009C200 File Offset: 0x0009A400
		public void SetLabelModeToConstantValue()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetLabelModeToConstantValue_40(base.GetCppThis());
		}

		// Token: 0x06006C2D RID: 27693
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetLabelModeToSeedScalar_41(HandleRef pThis);

		/// <summary>
		/// Set the mode for applying labels to the output.
		/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
		/// present, or the regions will be labeled consecutively starting at 1,
		/// if the seeds have no scalars. Labeling by SizeRank means that the
		/// largest region is labeled 1 and other regions are labeled consecutively
		/// in order of decreasing size (if there is a tie, then the seed point ID
		/// is used as a tiebreaker).  Finally, Constant means that all regions
		/// will have the value of SetLabelConstantValue().  The default is to
		/// label using the seed scalars, if present, or to label consecutively,
		/// if no seed scalars are present.
		/// </summary>
		// Token: 0x06006C2E RID: 27694 RVA: 0x0009C20F File Offset: 0x0009A40F
		public void SetLabelModeToSeedScalar()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetLabelModeToSeedScalar_41(base.GetCppThis());
		}

		// Token: 0x06006C2F RID: 27695
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetLabelModeToSizeRank_42(HandleRef pThis);

		/// <summary>
		/// Set the mode for applying labels to the output.
		/// Labeling by SeedScalar uses the scalars from the seeds as labels, if
		/// present, or the regions will be labeled consecutively starting at 1,
		/// if the seeds have no scalars. Labeling by SizeRank means that the
		/// largest region is labeled 1 and other regions are labeled consecutively
		/// in order of decreasing size (if there is a tie, then the seed point ID
		/// is used as a tiebreaker).  Finally, Constant means that all regions
		/// will have the value of SetLabelConstantValue().  The default is to
		/// label using the seed scalars, if present, or to label consecutively,
		/// if no seed scalars are present.
		/// </summary>
		// Token: 0x06006C30 RID: 27696 RVA: 0x0009C21E File Offset: 0x0009A41E
		public void SetLabelModeToSizeRank()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetLabelModeToSizeRank_42(base.GetCppThis());
		}

		// Token: 0x06006C31 RID: 27697
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetLabelScalarType_43(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the scalar type for the output label image.
		/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
		/// depending on how many labels are expected.  The default is UnsignedChar,
		/// which allows for 255 label values.  If the total number of regions is
		/// greater than the maximum label value N, then only the largest N regions
		/// will be kept and the rest will be discarded.
		/// </summary>
		// Token: 0x06006C32 RID: 27698 RVA: 0x0009C22D File Offset: 0x0009A42D
		public virtual void SetLabelScalarType(int _arg)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetLabelScalarType_43(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C33 RID: 27699
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetLabelScalarTypeToInt_44(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for the output label image.
		/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
		/// depending on how many labels are expected.  The default is UnsignedChar,
		/// which allows for 255 label values.  If the total number of regions is
		/// greater than the maximum label value N, then only the largest N regions
		/// will be kept and the rest will be discarded.
		/// </summary>
		// Token: 0x06006C34 RID: 27700 RVA: 0x0009C23D File Offset: 0x0009A43D
		public void SetLabelScalarTypeToInt()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetLabelScalarTypeToInt_44(base.GetCppThis());
		}

		// Token: 0x06006C35 RID: 27701
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetLabelScalarTypeToShort_45(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for the output label image.
		/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
		/// depending on how many labels are expected.  The default is UnsignedChar,
		/// which allows for 255 label values.  If the total number of regions is
		/// greater than the maximum label value N, then only the largest N regions
		/// will be kept and the rest will be discarded.
		/// </summary>
		// Token: 0x06006C36 RID: 27702 RVA: 0x0009C24C File Offset: 0x0009A44C
		public void SetLabelScalarTypeToShort()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetLabelScalarTypeToShort_45(base.GetCppThis());
		}

		// Token: 0x06006C37 RID: 27703
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetLabelScalarTypeToUnsignedChar_46(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for the output label image.
		/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
		/// depending on how many labels are expected.  The default is UnsignedChar,
		/// which allows for 255 label values.  If the total number of regions is
		/// greater than the maximum label value N, then only the largest N regions
		/// will be kept and the rest will be discarded.
		/// </summary>
		// Token: 0x06006C38 RID: 27704 RVA: 0x0009C25B File Offset: 0x0009A45B
		public void SetLabelScalarTypeToUnsignedChar()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetLabelScalarTypeToUnsignedChar_46(base.GetCppThis());
		}

		// Token: 0x06006C39 RID: 27705
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetLabelScalarTypeToUnsignedShort_47(HandleRef pThis);

		/// <summary>
		/// Set the scalar type for the output label image.
		/// This should be one of UnsignedChar, Short, UnsignedShort, or Int
		/// depending on how many labels are expected.  The default is UnsignedChar,
		/// which allows for 255 label values.  If the total number of regions is
		/// greater than the maximum label value N, then only the largest N regions
		/// will be kept and the rest will be discarded.
		/// </summary>
		// Token: 0x06006C3A RID: 27706 RVA: 0x0009C26A File Offset: 0x0009A46A
		public void SetLabelScalarTypeToUnsignedShort()
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetLabelScalarTypeToUnsignedShort_47(base.GetCppThis());
		}

		// Token: 0x06006C3B RID: 27707
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetScalarRange_48(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Set the scalar range used to define potential regions.
		/// Only voxels with values that are within this range will be considered
		/// for region membership.  This is an inclusive range, meaning that the
		/// upper and lower limits are considered to be within the range.  The
		/// default range goes from 0.5 to VTK_DOUBLE_MAX.
		/// </summary>
		// Token: 0x06006C3C RID: 27708 RVA: 0x0009C279 File Offset: 0x0009A479
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetScalarRange_48(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006C3D RID: 27709
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetScalarRange_49(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the scalar range used to define potential regions.
		/// Only voxels with values that are within this range will be considered
		/// for region membership.  This is an inclusive range, meaning that the
		/// upper and lower limits are considered to be within the range.  The
		/// default range goes from 0.5 to VTK_DOUBLE_MAX.
		/// </summary>
		// Token: 0x06006C3E RID: 27710 RVA: 0x0009C28A File Offset: 0x0009A48A
		public void SetScalarRange(IntPtr _arg)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetScalarRange_49(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C3F RID: 27711
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetSeedConnection_50(HandleRef pThis, HandleRef port);

		/// <summary>
		/// The input for seed locations (input port 1).
		/// Each point in the supplied data set will be used as a seed, unless
		/// the data set has scalars, in which case only the points with scalar
		/// values that are not equal to zero will be used as seeds.
		/// </summary>
		// Token: 0x06006C40 RID: 27712 RVA: 0x0009C29C File Offset: 0x0009A49C
		public void SetSeedConnection(vtkAlgorithmOutput port)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetSeedConnection_50(base.GetCppThis(), (port == null) ? default(HandleRef) : port.GetCppThis());
		}

		// Token: 0x06006C41 RID: 27713
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetSeedData_51(HandleRef pThis, HandleRef data);

		/// <summary>
		/// The input for seed locations (input port 1).
		/// Each point in the supplied data set will be used as a seed, unless
		/// the data set has scalars, in which case only the points with scalar
		/// values that are not equal to zero will be used as seeds.
		/// </summary>
		// Token: 0x06006C42 RID: 27714 RVA: 0x0009C2CC File Offset: 0x0009A4CC
		public void SetSeedData(vtkDataSet data)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetSeedData_51(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x06006C43 RID: 27715
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetSizeRange_52(HandleRef pThis, long _arg1, long _arg2);

		/// <summary>
		/// Set the size range for the extracted regions.
		/// Only regions that have sizes within the specified range will be present
		/// in the output.  The default range is (1, VTK_ID_MAX).
		/// </summary>
		// Token: 0x06006C44 RID: 27716 RVA: 0x0009C2FB File Offset: 0x0009A4FB
		public virtual void SetSizeRange(long _arg1, long _arg2)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetSizeRange_52(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x06006C45 RID: 27717
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetSizeRange_53(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the size range for the extracted regions.
		/// Only regions that have sizes within the specified range will be present
		/// in the output.  The default range is (1, VTK_ID_MAX).
		/// </summary>
		// Token: 0x06006C46 RID: 27718 RVA: 0x0009C30C File Offset: 0x0009A50C
		public void SetSizeRange(IntPtr _arg)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetSizeRange_53(base.GetCppThis(), _arg);
		}

		// Token: 0x06006C47 RID: 27719
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetStencilConnection_54(HandleRef pThis, HandleRef port);

		/// <summary>
		/// The input for a stencil (input port 2).
		/// The output labels will be restricted to the region inside the stencil,
		/// as if no input voxels existed outside the stencil.  This allows you to
		/// apply this filter within an arbitrary region of interest.
		/// </summary>
		// Token: 0x06006C48 RID: 27720 RVA: 0x0009C31C File Offset: 0x0009A51C
		public void SetStencilConnection(vtkAlgorithmOutput port)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetStencilConnection_54(base.GetCppThis(), (port == null) ? default(HandleRef) : port.GetCppThis());
		}

		// Token: 0x06006C49 RID: 27721
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConnectivityFilter_SetStencilData_55(HandleRef pThis, HandleRef data);

		/// <summary>
		/// The input for a stencil (input port 2).
		/// The output labels will be restricted to the region inside the stencil,
		/// as if no input voxels existed outside the stencil.  This allows you to
		/// apply this filter within an arbitrary region of interest.
		/// </summary>
		// Token: 0x06006C4A RID: 27722 RVA: 0x0009C34C File Offset: 0x0009A54C
		public void SetStencilData(vtkImageStencilData data)
		{
			vtkImageConnectivityFilter.vtkImageConnectivityFilter_SetStencilData_55(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000977 RID: 2423
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageConnectivityFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000978 RID: 2424
		public new static readonly string MRClassNameKey = "class vtkImageConnectivityFilter";

		/// <summary>
		/// Enum constants for SetExtractionMode().
		/// </summary>
		// Token: 0x02000244 RID: 580
		public enum ExtractionModeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400097A RID: 2426
			AllRegions = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400097B RID: 2427
			LargestRegion,
			/// <summary>enum member</summary>
			// Token: 0x0400097C RID: 2428
			SeededRegions = 0
		}

		/// <summary>
		/// Enum constants for SetLabelMode().
		/// </summary>
		// Token: 0x02000245 RID: 581
		public enum LabelModeEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x0400097E RID: 2430
			ConstantValue = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400097F RID: 2431
			SeedScalar = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000980 RID: 2432
			SizeRank = 2
		}
	}
}
