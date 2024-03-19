using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImagePadFilter
	/// </summary>
	/// <remarks>
	///    Super class for filters that fill in extra pixels.
	///
	/// vtkImagePadFilter Changes the image extent of an image.  If the image
	/// extent is larger than the input image extent, the extra pixels are
	/// filled by an algorithm determined by the subclass.
	/// The image extent of the output has to be specified.
	/// </remarks>
	// Token: 0x02000855 RID: 2133
	public class vtkImagePadFilter : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601621C RID: 90652 RVA: 0x001F27DC File Offset: 0x001F09DC
		static vtkImagePadFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImagePadFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePadFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601621D RID: 90653 RVA: 0x001F2804 File Offset: 0x001F0A04
		public vtkImagePadFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601621E RID: 90654
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePadFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601621F RID: 90655 RVA: 0x001F2814 File Offset: 0x001F0A14
		public new static vtkImagePadFilter New()
		{
			vtkImagePadFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePadFilter.vtkImagePadFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePadFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016220 RID: 90656 RVA: 0x001F2868 File Offset: 0x001F0A68
		public vtkImagePadFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImagePadFilter.vtkImagePadFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016221 RID: 90657 RVA: 0x001F28AC File Offset: 0x001F0AAC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016222 RID: 90658
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImagePadFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016223 RID: 90659 RVA: 0x001F28B8 File Offset: 0x001F0AB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImagePadFilter.vtkImagePadFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016224 RID: 90660
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImagePadFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016225 RID: 90661 RVA: 0x001F28D8 File Offset: 0x001F0AD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImagePadFilter.vtkImagePadFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016226 RID: 90662
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePadFilter_GetOutputNumberOfScalarComponents_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the number of output scalar components.
		/// </summary>
		// Token: 0x06016227 RID: 90663 RVA: 0x001F28F4 File Offset: 0x001F0AF4
		public virtual int GetOutputNumberOfScalarComponents()
		{
			return vtkImagePadFilter.vtkImagePadFilter_GetOutputNumberOfScalarComponents_03(base.GetCppThis());
		}

		// Token: 0x06016228 RID: 90664
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePadFilter_GetOutputWholeExtent_04(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// The image extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06016229 RID: 90665 RVA: 0x001F2913 File Offset: 0x001F0B13
		public void GetOutputWholeExtent(IntPtr extent)
		{
			vtkImagePadFilter.vtkImagePadFilter_GetOutputWholeExtent_04(base.GetCppThis(), extent);
		}

		// Token: 0x0601622A RID: 90666
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePadFilter_GetOutputWholeExtent_05(HandleRef pThis);

		/// <summary>
		/// The image extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x0601622B RID: 90667 RVA: 0x001F2924 File Offset: 0x001F0B24
		public int[] GetOutputWholeExtent()
		{
			IntPtr intPtr = vtkImagePadFilter.vtkImagePadFilter_GetOutputWholeExtent_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601622C RID: 90668
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePadFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601622D RID: 90669 RVA: 0x001F296C File Offset: 0x001F0B6C
		public override int IsA(string type)
		{
			return vtkImagePadFilter.vtkImagePadFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601622E RID: 90670
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImagePadFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601622F RID: 90671 RVA: 0x001F298C File Offset: 0x001F0B8C
		public new static int IsTypeOf(string type)
		{
			return vtkImagePadFilter.vtkImagePadFilter_IsTypeOf_07(type);
		}

		// Token: 0x06016230 RID: 90672
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePadFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016231 RID: 90673 RVA: 0x001F29A8 File Offset: 0x001F0BA8
		public new vtkImagePadFilter NewInstance()
		{
			vtkImagePadFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePadFilter.vtkImagePadFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePadFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016232 RID: 90674
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePadFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016233 RID: 90675 RVA: 0x001F2A04 File Offset: 0x001F0C04
		public new static vtkImagePadFilter SafeDownCast(vtkObjectBase o)
		{
			vtkImagePadFilter vtkImagePadFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImagePadFilter.vtkImagePadFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImagePadFilter = (vtkImagePadFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImagePadFilter.Register(null);
				}
			}
			return vtkImagePadFilter;
		}

		// Token: 0x06016234 RID: 90676
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePadFilter_SetOutputNumberOfScalarComponents_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the number of output scalar components.
		/// </summary>
		// Token: 0x06016235 RID: 90677 RVA: 0x001F2A83 File Offset: 0x001F0C83
		public virtual void SetOutputNumberOfScalarComponents(int _arg)
		{
			vtkImagePadFilter.vtkImagePadFilter_SetOutputNumberOfScalarComponents_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06016236 RID: 90678
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePadFilter_SetOutputWholeExtent_12(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// The image extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06016237 RID: 90679 RVA: 0x001F2A93 File Offset: 0x001F0C93
		public void SetOutputWholeExtent(IntPtr extent)
		{
			vtkImagePadFilter.vtkImagePadFilter_SetOutputWholeExtent_12(base.GetCppThis(), extent);
		}

		// Token: 0x06016238 RID: 90680
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePadFilter_SetOutputWholeExtent_13(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		/// <summary>
		/// The image extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06016239 RID: 90681 RVA: 0x001F2AA3 File Offset: 0x001F0CA3
		public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImagePadFilter.vtkImagePadFilter_SetOutputWholeExtent_13(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018FE RID: 6398
		public new const string MRFullTypeName = "Kitware.VTK.vtkImagePadFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018FF RID: 6399
		public new static readonly string MRClassNameKey = "class vtkImagePadFilter";
	}
}
