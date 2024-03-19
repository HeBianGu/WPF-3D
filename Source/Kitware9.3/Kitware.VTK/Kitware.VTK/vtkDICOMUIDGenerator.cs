using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	// Token: 0x02000046 RID: 70
	public class vtkDICOMUIDGenerator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06000C5B RID: 3163 RVA: 0x00018A72 File Offset: 0x00016C72
		static vtkDICOMUIDGenerator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDICOMUIDGenerator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMUIDGenerator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06000C5C RID: 3164 RVA: 0x00018A9A File Offset: 0x00016C9A
		public vtkDICOMUIDGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06000C5D RID: 3165
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUIDGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C5E RID: 3166 RVA: 0x00018AA8 File Offset: 0x00016CA8
		public new static vtkDICOMUIDGenerator New()
		{
			vtkDICOMUIDGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMUIDGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00018AFC File Offset: 0x00016CFC
		public vtkDICOMUIDGenerator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06000C60 RID: 3168 RVA: 0x00018B40 File Offset: 0x00016D40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06000C61 RID: 3169
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkDICOMUIDGenerator_GenerateUID_01(HandleRef pThis, HandleRef tag);

		// Token: 0x06000C62 RID: 3170 RVA: 0x00018B4C File Offset: 0x00016D4C
		public virtual string GenerateUID(vtkDICOMTag tag)
		{
			return vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_GenerateUID_01(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis());
		}

		// Token: 0x06000C63 RID: 3171
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMUIDGenerator_GenerateUIDs_02(HandleRef pThis, HandleRef tag, HandleRef uids);

		// Token: 0x06000C64 RID: 3172 RVA: 0x00018B80 File Offset: 0x00016D80
		public virtual void GenerateUIDs(vtkDICOMTag tag, vtkStringArray uids)
		{
			vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_GenerateUIDs_02(base.GetCppThis(), (tag == null) ? default(HandleRef) : tag.GetCppThis(), (uids == null) ? default(HandleRef) : uids.GetCppThis());
		}

		// Token: 0x06000C65 RID: 3173
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUIDGenerator_GetDefault_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C66 RID: 3174 RVA: 0x00018BC4 File Offset: 0x00016DC4
		public static vtkDICOMUIDGenerator GetDefault()
		{
			vtkDICOMUIDGenerator vtkDICOMUIDGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_GetDefault_03(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMUIDGenerator = (vtkDICOMUIDGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMUIDGenerator.Register(null);
				}
			}
			return vtkDICOMUIDGenerator;
		}

		// Token: 0x06000C67 RID: 3175
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMUIDGenerator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000C68 RID: 3176 RVA: 0x00018C30 File Offset: 0x00016E30
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06000C69 RID: 3177
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDICOMUIDGenerator_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000C6A RID: 3178 RVA: 0x00018C50 File Offset: 0x00016E50
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06000C6B RID: 3179
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUIDGenerator_GetUIDPrefix_06(HandleRef pThis);

		// Token: 0x06000C6C RID: 3180 RVA: 0x00018C6C File Offset: 0x00016E6C
		public string GetUIDPrefix()
		{
			string s = Marshal.PtrToStringAnsi(vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_GetUIDPrefix_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06000C6D RID: 3181
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMUIDGenerator_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000C6E RID: 3182 RVA: 0x00018CA8 File Offset: 0x00016EA8
		public override int IsA(string type)
		{
			return vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06000C6F RID: 3183
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDICOMUIDGenerator_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		// Token: 0x06000C70 RID: 3184 RVA: 0x00018CC8 File Offset: 0x00016EC8
		public new static int IsTypeOf(string type)
		{
			return vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_IsTypeOf_08(type);
		}

		// Token: 0x06000C71 RID: 3185
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUIDGenerator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C72 RID: 3186 RVA: 0x00018CE4 File Offset: 0x00016EE4
		public new vtkDICOMUIDGenerator NewInstance()
		{
			vtkDICOMUIDGenerator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDICOMUIDGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06000C73 RID: 3187
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDICOMUIDGenerator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		// Token: 0x06000C74 RID: 3188 RVA: 0x00018D40 File Offset: 0x00016F40
		public new static vtkDICOMUIDGenerator SafeDownCast(vtkObjectBase o)
		{
			vtkDICOMUIDGenerator vtkDICOMUIDGenerator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDICOMUIDGenerator = (vtkDICOMUIDGenerator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDICOMUIDGenerator.Register(null);
				}
			}
			return vtkDICOMUIDGenerator;
		}

		// Token: 0x06000C75 RID: 3189
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMUIDGenerator_SetDefault_12(HandleRef uidgen);

		// Token: 0x06000C76 RID: 3190 RVA: 0x00018DC0 File Offset: 0x00016FC0
		public static void SetDefault(vtkDICOMUIDGenerator uidgen)
		{
			vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_SetDefault_12((uidgen == null) ? default(HandleRef) : uidgen.GetCppThis());
		}

		// Token: 0x06000C77 RID: 3191
		[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDICOMUIDGenerator_SetUIDPrefix_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string prefix);

		// Token: 0x06000C78 RID: 3192 RVA: 0x00018DE9 File Offset: 0x00016FE9
		public void SetUIDPrefix(string prefix)
		{
			vtkDICOMUIDGenerator.vtkDICOMUIDGenerator_SetUIDPrefix_13(base.GetCppThis(), prefix);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003C0 RID: 960
		public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMUIDGenerator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040003C1 RID: 961
		public new static readonly string MRClassNameKey = "class vtkDICOMUIDGenerator";
	}
}
