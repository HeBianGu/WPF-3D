using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageItem
	/// </summary>
	/// <remarks>
	///    a vtkContextItem that draws a supplied image in the
	/// scene.
	///
	///
	/// This vtkContextItem draws the supplied image in the scene.
	/// </remarks>
	// Token: 0x020007B2 RID: 1970
	public class vtkImageItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060143C9 RID: 82889 RVA: 0x001C989A File Offset: 0x001C7A9A
		static vtkImageItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060143CA RID: 82890 RVA: 0x001C98C2 File Offset: 0x001C7AC2
		public vtkImageItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060143CB RID: 82891
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143CC RID: 82892 RVA: 0x001C98D0 File Offset: 0x001C7AD0
		public new static vtkImageItem New()
		{
			vtkImageItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageItem.vtkImageItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143CD RID: 82893 RVA: 0x001C9924 File Offset: 0x001C7B24
		public vtkImageItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageItem.vtkImageItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060143CE RID: 82894 RVA: 0x001C9968 File Offset: 0x001C7B68
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060143CF RID: 82895
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageItem_GetImage_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the image of the item.
		/// </summary>
		// Token: 0x060143D0 RID: 82896 RVA: 0x001C9974 File Offset: 0x001C7B74
		public virtual vtkImageData GetImage()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageItem.vtkImageItem_GetImage_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x060143D1 RID: 82897
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageItem_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143D2 RID: 82898 RVA: 0x001C99E4 File Offset: 0x001C7BE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageItem.vtkImageItem_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060143D3 RID: 82899
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageItem_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143D4 RID: 82900 RVA: 0x001C9A04 File Offset: 0x001C7C04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageItem.vtkImageItem_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060143D5 RID: 82901
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageItem_GetPosition_04(HandleRef pThis);

		/// <summary>
		/// Get the position of the bottom corner of the image.
		/// </summary>
		// Token: 0x060143D6 RID: 82902 RVA: 0x001C9A20 File Offset: 0x001C7C20
		public virtual float[] GetPosition()
		{
			IntPtr intPtr = vtkImageItem.vtkImageItem_GetPosition_04(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060143D7 RID: 82903
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageItem_GetPosition_05(HandleRef pThis, ref float _arg1, ref float _arg2);

		/// <summary>
		/// Get the position of the bottom corner of the image.
		/// </summary>
		// Token: 0x060143D8 RID: 82904 RVA: 0x001C9A68 File Offset: 0x001C7C68
		public virtual void GetPosition(ref float _arg1, ref float _arg2)
		{
			vtkImageItem.vtkImageItem_GetPosition_05(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x060143D9 RID: 82905
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageItem_GetPosition_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the position of the bottom corner of the image.
		/// </summary>
		// Token: 0x060143DA RID: 82906 RVA: 0x001C9A79 File Offset: 0x001C7C79
		public virtual void GetPosition(IntPtr _arg)
		{
			vtkImageItem.vtkImageItem_GetPosition_06(base.GetCppThis(), _arg);
		}

		// Token: 0x060143DB RID: 82907
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageItem_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143DC RID: 82908 RVA: 0x001C9A8C File Offset: 0x001C7C8C
		public override int IsA(string type)
		{
			return vtkImageItem.vtkImageItem_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060143DD RID: 82909
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageItem_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143DE RID: 82910 RVA: 0x001C9AAC File Offset: 0x001C7CAC
		public new static int IsTypeOf(string type)
		{
			return vtkImageItem.vtkImageItem_IsTypeOf_08(type);
		}

		// Token: 0x060143DF RID: 82911
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageItem_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143E0 RID: 82912 RVA: 0x001C9AC8 File Offset: 0x001C7CC8
		public new vtkImageItem NewInstance()
		{
			vtkImageItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageItem.vtkImageItem_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060143E1 RID: 82913
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageItem_Paint_11(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item.
		/// </summary>
		// Token: 0x060143E2 RID: 82914 RVA: 0x001C9B24 File Offset: 0x001C7D24
		public override bool Paint(vtkContext2D painter)
		{
			return vtkImageItem.vtkImageItem_Paint_11(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x060143E3 RID: 82915
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageItem_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060143E4 RID: 82916 RVA: 0x001C9B60 File Offset: 0x001C7D60
		public new static vtkImageItem SafeDownCast(vtkObjectBase o)
		{
			vtkImageItem vtkImageItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageItem.vtkImageItem_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageItem = (vtkImageItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageItem.Register(null);
				}
			}
			return vtkImageItem;
		}

		// Token: 0x060143E5 RID: 82917
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageItem_SetImage_13(HandleRef pThis, HandleRef image);

		/// <summary>
		/// Set the image of the item.
		/// </summary>
		// Token: 0x060143E6 RID: 82918 RVA: 0x001C9BE0 File Offset: 0x001C7DE0
		public void SetImage(vtkImageData image)
		{
			vtkImageItem.vtkImageItem_SetImage_13(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis());
		}

		// Token: 0x060143E7 RID: 82919
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageItem_SetPosition_14(HandleRef pThis, float _arg1, float _arg2);

		/// <summary>
		/// Set the position of the bottom corner of the image.
		/// </summary>
		// Token: 0x060143E8 RID: 82920 RVA: 0x001C9C0F File Offset: 0x001C7E0F
		public virtual void SetPosition(float _arg1, float _arg2)
		{
			vtkImageItem.vtkImageItem_SetPosition_14(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x060143E9 RID: 82921
		[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageItem_SetPosition_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the position of the bottom corner of the image.
		/// </summary>
		// Token: 0x060143EA RID: 82922 RVA: 0x001C9C20 File Offset: 0x001C7E20
		public void SetPosition(IntPtr _arg)
		{
			vtkImageItem.vtkImageItem_SetPosition_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001773 RID: 6003
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001774 RID: 6004
		public new static readonly string MRClassNameKey = "class vtkImageItem";
	}
}
