using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///  `vtkResourceStream` implementation for memory input.
	///
	/// `vtkMemoryResourceStream` can be a view on existing data.
	/// Or it can copy specified data into an internal buffer.
	/// Or it can take ownership of a `vtkBuffer`, a `std::vector` or a `std::string`.
	/// </remarks>
	// Token: 0x02000730 RID: 1840
	public class vtkMemoryResourceStream : vtkResourceStream
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013328 RID: 78632 RVA: 0x001B2547 File Offset: 0x001B0747
		static vtkMemoryResourceStream()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMemoryResourceStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMemoryResourceStream"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013329 RID: 78633 RVA: 0x001B256F File Offset: 0x001B076F
		public vtkMemoryResourceStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601332A RID: 78634
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMemoryResourceStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// @brief Simple single value container
		///
		/// This struct is used to manage stream owned buffer lifetime.
		/// Its only purpose is to be destroyer through its base class destructor.
		/// </summary>
		// Token: 0x0601332B RID: 78635 RVA: 0x001B2580 File Offset: 0x001B0780
		public new static vtkMemoryResourceStream New()
		{
			vtkMemoryResourceStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMemoryResourceStream.vtkMemoryResourceStream_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMemoryResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// @brief Simple single value container
		///
		/// This struct is used to manage stream owned buffer lifetime.
		/// Its only purpose is to be destroyer through its base class destructor.
		/// </summary>
		// Token: 0x0601332C RID: 78636 RVA: 0x001B25D4 File Offset: 0x001B07D4
		public vtkMemoryResourceStream() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMemoryResourceStream.vtkMemoryResourceStream_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601332D RID: 78637 RVA: 0x001B2618 File Offset: 0x001B0818
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601332E RID: 78638
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMemoryResourceStream_EndOfStream_01(HandleRef pThis);

		/// <summary>
		/// @brief Override vtkResourceStream functions
		/// </summary>
		// Token: 0x0601332F RID: 78639 RVA: 0x001B2624 File Offset: 0x001B0824
		public override bool EndOfStream()
		{
			return vtkMemoryResourceStream.vtkMemoryResourceStream_EndOfStream_01(base.GetCppThis()) != 0;
		}

		// Token: 0x06013330 RID: 78640
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMemoryResourceStream_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// @brief Simple single value container
		///
		/// This struct is used to manage stream owned buffer lifetime.
		/// Its only purpose is to be destroyer through its base class destructor.
		/// </summary>
		// Token: 0x06013331 RID: 78641 RVA: 0x001B264C File Offset: 0x001B084C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMemoryResourceStream.vtkMemoryResourceStream_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06013332 RID: 78642
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMemoryResourceStream_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// @brief Simple single value container
		///
		/// This struct is used to manage stream owned buffer lifetime.
		/// Its only purpose is to be destroyer through its base class destructor.
		/// </summary>
		// Token: 0x06013333 RID: 78643 RVA: 0x001B266C File Offset: 0x001B086C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMemoryResourceStream.vtkMemoryResourceStream_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06013334 RID: 78644
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMemoryResourceStream_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// @brief Simple single value container
		///
		/// This struct is used to manage stream owned buffer lifetime.
		/// Its only purpose is to be destroyer through its base class destructor.
		/// </summary>
		// Token: 0x06013335 RID: 78645 RVA: 0x001B2688 File Offset: 0x001B0888
		public override int IsA(string type)
		{
			return vtkMemoryResourceStream.vtkMemoryResourceStream_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06013336 RID: 78646
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMemoryResourceStream_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// @brief Simple single value container
		///
		/// This struct is used to manage stream owned buffer lifetime.
		/// Its only purpose is to be destroyer through its base class destructor.
		/// </summary>
		// Token: 0x06013337 RID: 78647 RVA: 0x001B26A8 File Offset: 0x001B08A8
		public new static int IsTypeOf(string type)
		{
			return vtkMemoryResourceStream.vtkMemoryResourceStream_IsTypeOf_05(type);
		}

		// Token: 0x06013338 RID: 78648
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMemoryResourceStream_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// @brief Simple single value container
		///
		/// This struct is used to manage stream owned buffer lifetime.
		/// Its only purpose is to be destroyer through its base class destructor.
		/// </summary>
		// Token: 0x06013339 RID: 78649 RVA: 0x001B26C4 File Offset: 0x001B08C4
		public new vtkMemoryResourceStream NewInstance()
		{
			vtkMemoryResourceStream result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMemoryResourceStream.vtkMemoryResourceStream_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMemoryResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601333A RID: 78650
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkMemoryResourceStream_OwnsBuffer_08(HandleRef pThis);

		/// <summary>
		/// @brief Check if `this` has a internally managed buffer
		///
		/// This is `true` after a call to `SetBuffer(vtkSmartPointer&lt;vtkBuffer&lt;T&gt;&gt;)`
		/// even if only the reference count is managed by the stream.
		///
		/// @return `true` if `this` manage streamed buffer, `false` otherwise.
		/// </summary>
		// Token: 0x0601333B RID: 78651 RVA: 0x001B2720 File Offset: 0x001B0920
		public bool OwnsBuffer()
		{
			return vtkMemoryResourceStream.vtkMemoryResourceStream_OwnsBuffer_08(base.GetCppThis()) != 0;
		}

		// Token: 0x0601333C RID: 78652
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMemoryResourceStream_Read_09(HandleRef pThis, IntPtr buffer, ulong bytes);

		/// <summary>
		/// @brief Override vtkResourceStream functions
		/// </summary>
		// Token: 0x0601333D RID: 78653 RVA: 0x001B2748 File Offset: 0x001B0948
		public override ulong Read(IntPtr buffer, ulong bytes)
		{
			return vtkMemoryResourceStream.vtkMemoryResourceStream_Read_09(base.GetCppThis(), buffer, bytes);
		}

		// Token: 0x0601333E RID: 78654
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMemoryResourceStream_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// @brief Simple single value container
		///
		/// This struct is used to manage stream owned buffer lifetime.
		/// Its only purpose is to be destroyer through its base class destructor.
		/// </summary>
		// Token: 0x0601333F RID: 78655 RVA: 0x001B276C File Offset: 0x001B096C
		public new static vtkMemoryResourceStream SafeDownCast(vtkObjectBase o)
		{
			vtkMemoryResourceStream vtkMemoryResourceStream = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMemoryResourceStream.vtkMemoryResourceStream_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMemoryResourceStream = (vtkMemoryResourceStream)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMemoryResourceStream.Register(null);
				}
			}
			return vtkMemoryResourceStream;
		}

		// Token: 0x06013340 RID: 78656
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMemoryResourceStream_Seek_11(HandleRef pThis, long pos, vtkResourceStream.SeekDirection dir);

		/// <summary>
		/// @brief Override vtkResourceStream functions
		/// </summary>
		// Token: 0x06013341 RID: 78657 RVA: 0x001B27EC File Offset: 0x001B09EC
		public override long Seek(long pos, vtkResourceStream.SeekDirection dir)
		{
			return vtkMemoryResourceStream.vtkMemoryResourceStream_Seek_11(base.GetCppThis(), pos, dir);
		}

		// Token: 0x06013342 RID: 78658
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMemoryResourceStream_SetBuffer_12(HandleRef pThis, IntPtr buffer, ulong size, byte copy);

		/// <summary>
		/// @brief Set buffer to stream
		///
		/// If `copy` is `false`, the source buffer must stay valid as it may be used.
		///
		/// Otherwise, if `copy` is `true`, given buffer will be copied into an internally managed buffer.
		/// If `size` is 0, this call won't allocate anything. If `size &gt; 0`,
		/// `buffer` must not be `nullptr` and must point to a contiguous buffer of at least `size` bytes.
		///
		/// Regardless of `copy` value, this function also has the following effects:
		/// - Reset stream position to `0`.
		/// - EndOfStream will return `true` if `size` is `0`, `false` otherwise.
		/// - Release currently owned buffer, if any.
		/// - Increase modified time.
		///
		/// @param buffer the buffer address, may be nullptr if `size` is 0.
		/// @param size the buffer size in bytes, may be 0.
		/// @param copy if `true` this function copies given buffer to an internally managed buffer.
		/// </summary>
		// Token: 0x06013343 RID: 78659 RVA: 0x001B280D File Offset: 0x001B0A0D
		public void SetBuffer(IntPtr buffer, ulong size, bool copy)
		{
			vtkMemoryResourceStream.vtkMemoryResourceStream_SetBuffer_12(base.GetCppThis(), buffer, size, copy ? (byte)1 : (byte)0);
		}

		// Token: 0x06013344 RID: 78660
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMemoryResourceStream_Tell_13(HandleRef pThis);

		/// <summary>
		/// @brief Override vtkResourceStream functions
		/// </summary>
		// Token: 0x06013345 RID: 78661 RVA: 0x001B2828 File Offset: 0x001B0A28
		public override long Tell()
		{
			return vtkMemoryResourceStream.vtkMemoryResourceStream_Tell_13(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400162E RID: 5678
		public new const string MRFullTypeName = "Kitware.VTK.vtkMemoryResourceStream";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400162F RID: 5679
		public new static readonly string MRClassNameKey = "class vtkMemoryResourceStream";
	}
}
