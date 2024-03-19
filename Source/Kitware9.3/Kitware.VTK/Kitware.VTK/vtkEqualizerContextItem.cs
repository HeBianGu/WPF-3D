using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkEqualizerContextItem
	///
	/// </summary>
	/// <remarks>
	///  draws a interactive polyline
	///
	/// This is a vtkContextItem that can be placed into a vtkContextScene.
	/// It draws a polyline, and reacts to mouse events.
	/// Initially there are 2 points at the ends of the line.
	/// Provides the ability to add, remove, and move anchor points.
	/// This is not a universal polyline and is designed to adjust the reference points for the digital
	/// signal processing algorithm. So there are a number of features for interacting with the line:
	/// - the horizontal axis is frequencies; the values are of the integer type and cannot be negative
	/// - the vertical axis is the gains; the values are of the double type and cannot be negative
	/// - each reference point is limited by the values of neighboring points on the x-axis
	/// </remarks>
	// Token: 0x02000314 RID: 788
	public class vtkEqualizerContextItem : vtkContextItem
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008DA5 RID: 36261 RVA: 0x000C9ED0 File Offset: 0x000C80D0
		static vtkEqualizerContextItem()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEqualizerContextItem.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEqualizerContextItem"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008DA6 RID: 36262 RVA: 0x000C9EF8 File Offset: 0x000C80F8
		public vtkEqualizerContextItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008DA7 RID: 36263
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEqualizerContextItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008DA8 RID: 36264 RVA: 0x000C9F08 File Offset: 0x000C8108
		public new static vtkEqualizerContextItem New()
		{
			vtkEqualizerContextItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEqualizerContextItem.vtkEqualizerContextItem_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEqualizerContextItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008DA9 RID: 36265 RVA: 0x000C9F5C File Offset: 0x000C815C
		public vtkEqualizerContextItem() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEqualizerContextItem.vtkEqualizerContextItem_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008DAA RID: 36266 RVA: 0x000C9FA0 File Offset: 0x000C81A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008DAB RID: 36267
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEqualizerContextItem_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008DAC RID: 36268 RVA: 0x000C9FAC File Offset: 0x000C81AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEqualizerContextItem.vtkEqualizerContextItem_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06008DAD RID: 36269
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEqualizerContextItem_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008DAE RID: 36270 RVA: 0x000C9FCC File Offset: 0x000C81CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEqualizerContextItem.vtkEqualizerContextItem_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06008DAF RID: 36271
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkEqualizerContextItem_GetPoints_03(HandleRef pThis);

		/// <summary>
		/// Set / Get anchor points in the following format
		/// "P1x,P1y;P2x,P2y; ... PNx,PNy;"
		/// where X denotes the frequency, typeid(x) = int
		/// and Y denotes the gain, typeid(y) = float
		/// "0,1;500,1;" by default
		/// </summary>
		// Token: 0x06008DB0 RID: 36272 RVA: 0x000C9FE8 File Offset: 0x000C81E8
		public string GetPoints()
		{
			return vtkEqualizerContextItem.vtkEqualizerContextItem_GetPoints_03(base.GetCppThis());
		}

		// Token: 0x06008DB1 RID: 36273
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEqualizerContextItem_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008DB2 RID: 36274 RVA: 0x000CA008 File Offset: 0x000C8208
		public override int IsA(string type)
		{
			return vtkEqualizerContextItem.vtkEqualizerContextItem_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06008DB3 RID: 36275
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEqualizerContextItem_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008DB4 RID: 36276 RVA: 0x000CA028 File Offset: 0x000C8228
		public new static int IsTypeOf(string type)
		{
			return vtkEqualizerContextItem.vtkEqualizerContextItem_IsTypeOf_05(type);
		}

		// Token: 0x06008DB5 RID: 36277
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEqualizerContextItem_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008DB6 RID: 36278 RVA: 0x000CA044 File Offset: 0x000C8244
		public new vtkEqualizerContextItem NewInstance()
		{
			vtkEqualizerContextItem result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEqualizerContextItem.vtkEqualizerContextItem_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEqualizerContextItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008DB7 RID: 36279
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkEqualizerContextItem_Paint_08(HandleRef pThis, HandleRef painter);

		/// <summary>
		/// Paint event for the item, called whenever the item needs to be drawn.
		/// </summary>
		// Token: 0x06008DB8 RID: 36280 RVA: 0x000CA0A0 File Offset: 0x000C82A0
		public override bool Paint(vtkContext2D painter)
		{
			return vtkEqualizerContextItem.vtkEqualizerContextItem_Paint_08(base.GetCppThis(), (painter == null) ? default(HandleRef) : painter.GetCppThis()) != 0;
		}

		// Token: 0x06008DB9 RID: 36281
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEqualizerContextItem_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008DBA RID: 36282 RVA: 0x000CA0DC File Offset: 0x000C82DC
		public new static vtkEqualizerContextItem SafeDownCast(vtkObjectBase o)
		{
			vtkEqualizerContextItem vtkEqualizerContextItem = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEqualizerContextItem.vtkEqualizerContextItem_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEqualizerContextItem = (vtkEqualizerContextItem)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEqualizerContextItem.Register(null);
				}
			}
			return vtkEqualizerContextItem;
		}

		// Token: 0x06008DBB RID: 36283
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEqualizerContextItem_SetPoints_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string points);

		/// <summary>
		/// Set / Get anchor points in the following format
		/// "P1x,P1y;P2x,P2y; ... PNx,PNy;"
		/// where X denotes the frequency, typeid(x) = int
		/// and Y denotes the gain, typeid(y) = float
		/// "0,1;500,1;" by default
		/// </summary>
		// Token: 0x06008DBC RID: 36284 RVA: 0x000CA15B File Offset: 0x000C835B
		public void SetPoints(string points)
		{
			vtkEqualizerContextItem.vtkEqualizerContextItem_SetPoints_10(base.GetCppThis(), points);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BD8 RID: 3032
		public new const string MRFullTypeName = "Kitware.VTK.vtkEqualizerContextItem";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BD9 RID: 3033
		public new static readonly string MRClassNameKey = "class vtkEqualizerContextItem";
	}
}
