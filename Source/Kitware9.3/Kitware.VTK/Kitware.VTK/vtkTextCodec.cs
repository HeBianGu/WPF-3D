using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextCodec
	/// </summary>
	/// <remarks>
	///    Virtual class to act as an interface for all text codecs
	///
	///
	/// A virtual class interface for codecs that readers/writers can rely on
	///
	/// @par Thanks:
	/// Thanks to Tim Shed from Sandia National Laboratories for his work
	/// on the concepts and to Marcus Hanwell and Jeff Baumes of Kitware for
	/// keeping me out of the weeds
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextCodecFactory
	///
	/// </seealso>
	// Token: 0x02000720 RID: 1824
	public abstract class vtkTextCodec : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601317F RID: 78207 RVA: 0x001AFB1D File Offset: 0x001ADD1D
		static vtkTextCodec()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextCodec.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextCodec"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013180 RID: 78208 RVA: 0x001AFB45 File Offset: 0x001ADD45
		public vtkTextCodec(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013181 RID: 78209 RVA: 0x001AFB53 File Offset: 0x001ADD53
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013182 RID: 78210
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTextCodec_CanHandle_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string NameString);

		/// <summary>
		/// The name this codec goes by - should match the string the factory will take
		/// to create it
		/// </summary>
		// Token: 0x06013183 RID: 78211 RVA: 0x001AFB60 File Offset: 0x001ADD60
		public virtual bool CanHandle(string NameString)
		{
			return vtkTextCodec.vtkTextCodec_CanHandle_01(base.GetCppThis(), NameString) != 0;
		}

		// Token: 0x06013184 RID: 78212
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextCodec_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013185 RID: 78213 RVA: 0x001AFB88 File Offset: 0x001ADD88
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextCodec.vtkTextCodec_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06013186 RID: 78214
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextCodec_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013187 RID: 78215 RVA: 0x001AFBA8 File Offset: 0x001ADDA8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextCodec.vtkTextCodec_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06013188 RID: 78216
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextCodec_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013189 RID: 78217 RVA: 0x001AFBC4 File Offset: 0x001ADDC4
		public override int IsA(string type)
		{
			return vtkTextCodec.vtkTextCodec_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601318A RID: 78218
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextCodec_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601318B RID: 78219 RVA: 0x001AFBE4 File Offset: 0x001ADDE4
		public new static int IsTypeOf(string type)
		{
			return vtkTextCodec.vtkTextCodec_IsTypeOf_05(type);
		}

		// Token: 0x0601318C RID: 78220
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextCodec_Name_06(HandleRef pThis);

		/// <summary>
		/// The name this codec goes by - should match the string the factory will take
		/// to create it
		/// </summary>
		// Token: 0x0601318D RID: 78221 RVA: 0x001AFC00 File Offset: 0x001ADE00
		public virtual string Name()
		{
			string s = Marshal.PtrToStringAnsi(vtkTextCodec.vtkTextCodec_Name_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601318E RID: 78222
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextCodec_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601318F RID: 78223 RVA: 0x001AFC3C File Offset: 0x001ADE3C
		public new vtkTextCodec NewInstance()
		{
			vtkTextCodec result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextCodec.vtkTextCodec_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013190 RID: 78224
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextCodec_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013191 RID: 78225 RVA: 0x001AFC98 File Offset: 0x001ADE98
		public new static vtkTextCodec SafeDownCast(vtkObjectBase o)
		{
			vtkTextCodec vtkTextCodec = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextCodec.vtkTextCodec_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextCodec = (vtkTextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextCodec.Register(null);
				}
			}
			return vtkTextCodec;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400160C RID: 5644
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextCodec";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400160D RID: 5645
		public new static readonly string MRClassNameKey = "class vtkTextCodec";
	}
}
