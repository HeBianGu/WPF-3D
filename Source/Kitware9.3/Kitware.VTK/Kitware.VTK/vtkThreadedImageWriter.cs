using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///     vtkThreadedImageWriter
	/// </summary>
	/// <remarks>
	///     class used to compress/write images using threads to prevent
	///           locking while encoding data.
	///
	/// @details  This writer allow to encode an image data based on its file
	///           extension: tif, tiff, bpm, png, jpg, jpeg, vti, Z, ppm, raw
	///
	/// @author   Patricia Kroll Fasel @ LANL
	/// </remarks>
	// Token: 0x020001E6 RID: 486
	public class vtkThreadedImageWriter : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005CBC RID: 23740 RVA: 0x000865E7 File Offset: 0x000847E7
		static vtkThreadedImageWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThreadedImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreadedImageWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005CBD RID: 23741 RVA: 0x0008660F File Offset: 0x0008480F
		public vtkThreadedImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005CBE RID: 23742
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CBF RID: 23743 RVA: 0x00086620 File Offset: 0x00084820
		public new static vtkThreadedImageWriter New()
		{
			vtkThreadedImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedImageWriter.vtkThreadedImageWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadedImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CC0 RID: 23744 RVA: 0x00086674 File Offset: 0x00084874
		public vtkThreadedImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkThreadedImageWriter.vtkThreadedImageWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005CC1 RID: 23745 RVA: 0x000866B8 File Offset: 0x000848B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005CC2 RID: 23746
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageWriter_EncodeAndWrite_01(HandleRef pThis, HandleRef image, [MarshalAs(UnmanagedType.LPUTF8Str)] string fileName);

		/// <summary>
		/// Push an image into the threaded writer. It is not safe to modify the image
		/// after this point.
		/// You may run into thread safety issues. Typically, the caller code will
		/// simply release reference to the data and stop using it.
		/// </summary>
		// Token: 0x06005CC3 RID: 23747 RVA: 0x000866C4 File Offset: 0x000848C4
		public void EncodeAndWrite(vtkImageData image, string fileName)
		{
			vtkThreadedImageWriter.vtkThreadedImageWriter_EncodeAndWrite_01(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), fileName);
		}

		// Token: 0x06005CC4 RID: 23748
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageWriter_Finalize_02(HandleRef pThis);

		/// <summary>
		/// This method will wait for any running thread to terminate.
		/// </summary>
		// Token: 0x06005CC5 RID: 23749 RVA: 0x000866F4 File Offset: 0x000848F4
		public void FinalizeWrapper()
		{
			vtkThreadedImageWriter.vtkThreadedImageWriter_Finalize_02(base.GetCppThis());
		}

		// Token: 0x06005CC6 RID: 23750
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkThreadedImageWriter_GetMaxThreads_03(HandleRef pThis);

		/// <summary>
		/// Define the number of worker thread to use.
		/// Initialize() need to be called after any thread count change.
		/// </summary>
		// Token: 0x06005CC7 RID: 23751 RVA: 0x00086704 File Offset: 0x00084904
		public virtual uint GetMaxThreads()
		{
			return vtkThreadedImageWriter.vtkThreadedImageWriter_GetMaxThreads_03(base.GetCppThis());
		}

		// Token: 0x06005CC8 RID: 23752
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreadedImageWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CC9 RID: 23753 RVA: 0x00086724 File Offset: 0x00084924
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkThreadedImageWriter.vtkThreadedImageWriter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06005CCA RID: 23754
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkThreadedImageWriter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CCB RID: 23755 RVA: 0x00086744 File Offset: 0x00084944
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkThreadedImageWriter.vtkThreadedImageWriter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06005CCC RID: 23756
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageWriter_Initialize_06(HandleRef pThis);

		/// <summary>
		/// Need to be called at least once before using the class.
		/// Then it should be called again after any change on the
		/// thread count or if Finalize() was called.
		///
		/// This method will wait for any running thread to terminate and start
		/// a new pool with the given number of threads.
		/// </summary>
		// Token: 0x06005CCD RID: 23757 RVA: 0x0008675E File Offset: 0x0008495E
		public void Initialize()
		{
			vtkThreadedImageWriter.vtkThreadedImageWriter_Initialize_06(base.GetCppThis());
		}

		// Token: 0x06005CCE RID: 23758
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageWriter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CCF RID: 23759 RVA: 0x00086770 File Offset: 0x00084970
		public override int IsA(string type)
		{
			return vtkThreadedImageWriter.vtkThreadedImageWriter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06005CD0 RID: 23760
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkThreadedImageWriter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CD1 RID: 23761 RVA: 0x00086790 File Offset: 0x00084990
		public new static int IsTypeOf(string type)
		{
			return vtkThreadedImageWriter.vtkThreadedImageWriter_IsTypeOf_08(type);
		}

		// Token: 0x06005CD2 RID: 23762
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedImageWriter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CD3 RID: 23763 RVA: 0x000867AC File Offset: 0x000849AC
		public new vtkThreadedImageWriter NewInstance()
		{
			vtkThreadedImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedImageWriter.vtkThreadedImageWriter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThreadedImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005CD4 RID: 23764
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkThreadedImageWriter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005CD5 RID: 23765 RVA: 0x00086808 File Offset: 0x00084A08
		public new static vtkThreadedImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkThreadedImageWriter vtkThreadedImageWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkThreadedImageWriter.vtkThreadedImageWriter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThreadedImageWriter = (vtkThreadedImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThreadedImageWriter.Register(null);
				}
			}
			return vtkThreadedImageWriter;
		}

		// Token: 0x06005CD6 RID: 23766
		[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkThreadedImageWriter_SetMaxThreads_12(HandleRef pThis, uint arg0);

		/// <summary>
		/// Define the number of worker thread to use.
		/// Initialize() need to be called after any thread count change.
		/// </summary>
		// Token: 0x06005CD7 RID: 23767 RVA: 0x00086887 File Offset: 0x00084A87
		public void SetMaxThreads(uint arg0)
		{
			vtkThreadedImageWriter.vtkThreadedImageWriter_SetMaxThreads_12(base.GetCppThis(), arg0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000896 RID: 2198
		public new const string MRFullTypeName = "Kitware.VTK.vtkThreadedImageWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000897 RID: 2199
		public new static readonly string MRClassNameKey = "class vtkThreadedImageWriter";
	}
}
