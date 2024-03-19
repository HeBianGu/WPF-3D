using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBlankStructuredGridWithImage
	/// </summary>
	/// <remarks>
	///    blank a structured grid with an image
	///
	/// This filter can be used to set the blanking in a structured grid with
	/// an image. The filter takes two inputs: the structured grid to blank,
	/// and the image used to set the blanking. Make sure that the dimensions of
	/// both the image and the structured grid are identical.
	///
	/// Note that the image is interpreted as follows: zero values indicate that
	/// the structured grid point is blanked; non-zero values indicate that the
	/// structured grid point is visible. The blanking data must be unsigned char.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkStructuredGrid
	/// </seealso>
	// Token: 0x02000875 RID: 2165
	public class vtkBlankStructuredGridWithImage : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601678C RID: 92044 RVA: 0x001F9897 File Offset: 0x001F7A97
		static vtkBlankStructuredGridWithImage()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBlankStructuredGridWithImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlankStructuredGridWithImage"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601678D RID: 92045 RVA: 0x001F98BF File Offset: 0x001F7ABF
		public vtkBlankStructuredGridWithImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601678E RID: 92046
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlankStructuredGridWithImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601678F RID: 92047 RVA: 0x001F98D0 File Offset: 0x001F7AD0
		public new static vtkBlankStructuredGridWithImage New()
		{
			vtkBlankStructuredGridWithImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlankStructuredGridWithImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016790 RID: 92048 RVA: 0x001F9924 File Offset: 0x001F7B24
		public vtkBlankStructuredGridWithImage() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016791 RID: 92049 RVA: 0x001F9968 File Offset: 0x001F7B68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016792 RID: 92050
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlankStructuredGridWithImage_GetBlankingInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the input image used to perform the blanking.
		/// </summary>
		// Token: 0x06016793 RID: 92051 RVA: 0x001F9974 File Offset: 0x001F7B74
		public vtkImageData GetBlankingInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_GetBlankingInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06016794 RID: 92052
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBlankStructuredGridWithImage_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016795 RID: 92053 RVA: 0x001F99E4 File Offset: 0x001F7BE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06016796 RID: 92054
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBlankStructuredGridWithImage_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016797 RID: 92055 RVA: 0x001F9A04 File Offset: 0x001F7C04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06016798 RID: 92056
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlankStructuredGridWithImage_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016799 RID: 92057 RVA: 0x001F9A20 File Offset: 0x001F7C20
		public override int IsA(string type)
		{
			return vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601679A RID: 92058
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlankStructuredGridWithImage_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601679B RID: 92059 RVA: 0x001F9A40 File Offset: 0x001F7C40
		public new static int IsTypeOf(string type)
		{
			return vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_IsTypeOf_05(type);
		}

		// Token: 0x0601679C RID: 92060
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlankStructuredGridWithImage_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601679D RID: 92061 RVA: 0x001F9A5C File Offset: 0x001F7C5C
		public new vtkBlankStructuredGridWithImage NewInstance()
		{
			vtkBlankStructuredGridWithImage result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlankStructuredGridWithImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601679E RID: 92062
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlankStructuredGridWithImage_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601679F RID: 92063 RVA: 0x001F9AB8 File Offset: 0x001F7CB8
		public new static vtkBlankStructuredGridWithImage SafeDownCast(vtkObjectBase o)
		{
			vtkBlankStructuredGridWithImage vtkBlankStructuredGridWithImage = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBlankStructuredGridWithImage = (vtkBlankStructuredGridWithImage)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBlankStructuredGridWithImage.Register(null);
				}
			}
			return vtkBlankStructuredGridWithImage;
		}

		// Token: 0x060167A0 RID: 92064
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBlankStructuredGridWithImage_SetBlankingInputData_09(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set / get the input image used to perform the blanking.
		/// </summary>
		// Token: 0x060167A1 RID: 92065 RVA: 0x001F9B38 File Offset: 0x001F7D38
		public void SetBlankingInputData(vtkImageData input)
		{
			vtkBlankStructuredGridWithImage.vtkBlankStructuredGridWithImage_SetBlankingInputData_09(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001940 RID: 6464
		public new const string MRFullTypeName = "Kitware.VTK.vtkBlankStructuredGridWithImage";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001941 RID: 6465
		public new static readonly string MRClassNameKey = "class vtkBlankStructuredGridWithImage";
	}
}
