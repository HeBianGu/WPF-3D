using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageFourierCenter
	/// </summary>
	/// <remarks>
	///    Shifts constant frequency to center for
	/// display.
	///
	/// Is used for displaying images in frequency space.  FFT converts spatial
	/// images into frequency space, but puts the zero frequency at the origin.
	/// This filter shifts the zero frequency to the center of the image.
	/// Input and output are assumed to be doubles.
	/// </remarks>
	// Token: 0x0200025F RID: 607
	public class vtkImageFourierCenter : vtkImageDecomposeFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006FD6 RID: 28630 RVA: 0x000A11B7 File Offset: 0x0009F3B7
		static vtkImageFourierCenter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageFourierCenter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageFourierCenter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006FD7 RID: 28631 RVA: 0x000A11DF File Offset: 0x0009F3DF
		public vtkImageFourierCenter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006FD8 RID: 28632
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFourierCenter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FD9 RID: 28633 RVA: 0x000A11F0 File Offset: 0x0009F3F0
		public new static vtkImageFourierCenter New()
		{
			vtkImageFourierCenter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFourierCenter.vtkImageFourierCenter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFourierCenter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FDA RID: 28634 RVA: 0x000A1244 File Offset: 0x0009F444
		public vtkImageFourierCenter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageFourierCenter.vtkImageFourierCenter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006FDB RID: 28635 RVA: 0x000A1288 File Offset: 0x0009F488
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006FDC RID: 28636
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageFourierCenter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FDD RID: 28637 RVA: 0x000A1294 File Offset: 0x0009F494
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageFourierCenter.vtkImageFourierCenter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006FDE RID: 28638
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageFourierCenter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FDF RID: 28639 RVA: 0x000A12B4 File Offset: 0x0009F4B4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageFourierCenter.vtkImageFourierCenter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006FE0 RID: 28640
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFourierCenter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FE1 RID: 28641 RVA: 0x000A12D0 File Offset: 0x0009F4D0
		public override int IsA(string type)
		{
			return vtkImageFourierCenter.vtkImageFourierCenter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006FE2 RID: 28642
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageFourierCenter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FE3 RID: 28643 RVA: 0x000A12F0 File Offset: 0x0009F4F0
		public new static int IsTypeOf(string type)
		{
			return vtkImageFourierCenter.vtkImageFourierCenter_IsTypeOf_04(type);
		}

		// Token: 0x06006FE4 RID: 28644
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFourierCenter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FE5 RID: 28645 RVA: 0x000A130C File Offset: 0x0009F50C
		public new vtkImageFourierCenter NewInstance()
		{
			vtkImageFourierCenter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFourierCenter.vtkImageFourierCenter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFourierCenter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006FE6 RID: 28646
		[DllImport("Kitware.VTK.ImagingFourier.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageFourierCenter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006FE7 RID: 28647 RVA: 0x000A1368 File Offset: 0x0009F568
		public new static vtkImageFourierCenter SafeDownCast(vtkObjectBase o)
		{
			vtkImageFourierCenter vtkImageFourierCenter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageFourierCenter.vtkImageFourierCenter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageFourierCenter = (vtkImageFourierCenter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageFourierCenter.Register(null);
				}
			}
			return vtkImageFourierCenter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009B3 RID: 2483
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageFourierCenter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009B4 RID: 2484
		public new static readonly string MRClassNameKey = "class vtkImageFourierCenter";
	}
}
